using System.Windows.Forms;
using Entity;
using Repository;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма регистрации арендатора. 
    /// </summary>
    public partial class RegistrationTenant : Form
    {
        /// <summary>
        /// Главная форма.
        /// </summary>
        private MainForm Form { get; }
        
        public RegistrationTenant(MainForm form)
        {
            InitializeComponent();

            Form = form;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Сохарнить".
        /// </summary>
        private void Button_Save_Click(object sender, System.EventArgs e)
        {
            Service.GetProviderTenant().AddTenant(new Tenant
            {
                Fio = textBox_Fio.Text,
                Age = int.Parse(numericUpDown_Age.Text),
                Gender = domainUpDown_Gender.SelectedItem.Equals("Мужской")
                    ? 'м'
                    : 'ж',
                RegionId = 2
            });

            Button_Close_Click(sender, e);
        }
        
        /// <summary>
        /// Обработчик события нажатия на кнопку "Закрыть".
        /// </summary>
        private void Button_Close_Click(object sender, System.EventArgs e)
        {
            Close();
            Form.Visible = true;
        }
    }
}