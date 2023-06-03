using System;
using System.Drawing;
using System.Windows.Forms;
using Repository;
using Repository.Provider;

namespace RentSummerInventory
{
    public partial class ReadBooking : Form
    {
        /// <summary>
        /// Провайдер в таблицу "Арендодателя".
        /// </summary>
        private BookingLinqProvider Repository { get; }

        /// <summary>
        /// Главная форма.
        /// </summary>
        private MainForm MainForm { get; }

        public ReadBooking(MainForm mainForm)
        {
            InitializeComponent();

            dataGridView_Boking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Boking.Font = new Font("Microsoft Sans Serif", 12);

            MainForm = mainForm;
            var heads = new[]
            {
                "Id", "ФИО", "Возраст", "Дата окончания"
            };

            foreach (var head in heads)
            {
                dataGridView_Boking.Columns.Add(head, head);
            }

            dataGridView_Boking.Columns[0].Width = 50;

            Repository = Service.GetProviderBooking();
            var bookings = Repository.GetBookings();

            foreach (var booking in bookings)
            {
                dataGridView_Boking.Rows.Add(booking.TenantId, booking.Tenant.Fio, booking.Tenant.Age, booking.DateEnd);
            }
        }

        #region Форма для чтения

        private void toolStrip_Inventory_Click(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            Close();
        }

        private void toolStrip_Rent_Click(object sender, EventArgs e)
        {
            var rents = new ReadRents(MainForm);
            rents.Visible = true;
            Close();
        }

        private void toolStrip_Tenants_Click(object sender, EventArgs e)
        {
            var rents = new ReadTenants(MainForm);
            rents.Visible = true;
            Close();
        }

        #endregion
    }
}