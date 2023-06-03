using System;
using System.Drawing;
using System.Windows.Forms;
using Repository;
using Repository.Provider;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма Аренды.
    /// </summary>
    public partial class ReadRents : Form
    {
        /// <summary>
        /// Провайдер в таблицу "Арендодателя".
        /// </summary>
        private RentLinqProvider Repository { get; }

        /// <summary>
        /// Форма, в которой произошел вызов.
        /// </summary>
        private MainForm MainForm { get; }

        public ReadRents(MainForm form)
        {
            InitializeComponent();

            dataGridView_Rents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Rents.Font = new Font("Microsoft Sans Serif", 12);

            MainForm = form;
            var heads = new[]
            {
                "Id", "ФИО", "Цена за аренду", "Дата начала", "Дата окончания", "Весь депозит", "Количество инвентаря",
                "Аренда в процессе"
            };

            foreach (var head in heads)
            {
                dataGridView_Rents.Columns.Add(head, head);
            }

            dataGridView_Rents.Columns[0].Width = 50;

            Repository = Service.GetProviderRent();
            var rents = Repository.GetRents();

            foreach (var rent in rents)
            {
                dataGridView_Rents.Rows.Add(rent.RentId, rent.Tenant.Fio, rent.PriceRent, rent.DateStart,
                    rent.DateEnd, rent.AllPriceDeposit, rent.CountInventory, rent.IsRent);
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Сохранить".
        /// </summary>
        private void button_Save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Закрыть".
        /// </summary>
        private void button_Exit_Click(object sender, EventArgs e) => toolStrip_Inventory_Click(sender, e);

        #region Открытия других окон

        private void toolStrip_Inventory_Click(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            Close();
        }

        private void toolStrip_Tenants_Click(object sender, EventArgs e)
        {
            var rents = new ReadTenants(MainForm);
            rents.Visible = true;
            Close();
        }

        private void toolStrip_Booking_Click(object sender, EventArgs e)
        {
            var rents = new ReadBooking(MainForm);
            rents.Visible = true;
            Close();
        }

        #endregion
    }
}