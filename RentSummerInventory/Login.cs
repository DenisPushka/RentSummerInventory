using System;
using System.Windows.Forms;
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма аунтефикации пользователя.
    /// </summary>
    public partial class Login : Form
    {
        private const int Logon32ProviderDefault = 0;
        private const int Logon32LogonInteractive = 2;

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool LogonUser(string lpszUsername,
            string lpszDomain,
            string lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            out IntPtr phToken
        );

        [DllImport("kernel32.dll")]
        private static extern int FormatMessage(int dwFlags, ref IntPtr lpSource, int dwMessageId, int dwLanguageId,
            ref string lpBuffer, int nSize, ref IntPtr arguments);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Войти".
        /// </summary>
        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                var machineName = Environment.MachineName;
                var userName = textBox_Login.Text;
                var pwd = textBox_Password.Text;

                if (LogonUser(userName, machineName, pwd,
                        Logon32LogonInteractive, Logon32ProviderDefault, out var tokenHandle))
                {
                    var newId = new WindowsIdentity(tokenHandle);
                    var windowsPrincipal = new WindowsPrincipal(newId);

                    Visible = false;
                    var mainForm = new MainForm
                    {
                        Visible = true
                    };
                }
                else
                {
                    var ret = Marshal.GetLastWin32Error();
                    var errors = GetErrorMessage(ret);
                    MessageBox.Show(errors);
                }

                CloseHandle(tokenHandle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Exception occurred. {ex.Message}");
            }
        }

        /// <summary>
        /// Получени и отображение ошибки.
        /// </summary>
        /// <param name="errorCode">Код ошибки.</param>
        private static string GetErrorMessage(int errorCode)
        {
            const int formatMessageAllocateBuffer = 0x100;
            const int formatMessageIgnoreInserts = 0x200;
            const int formatMessageFromSystem = 0x1000;

            const int msgSize = 255;
            string lpMsgBuf = null;
            const int dwFlags = formatMessageAllocateBuffer | formatMessageFromSystem | formatMessageIgnoreInserts;

            var lpSource = IntPtr.Zero;
            var lpArguments = IntPtr.Zero;

            if (FormatMessage(dwFlags, ref lpSource, errorCode, 0, ref lpMsgBuf, msgSize, ref lpArguments) == 0)
            {
                throw new Exception("Failed to format message for error code " + errorCode + ". ");
            }

            return lpMsgBuf;
        }
    }
}