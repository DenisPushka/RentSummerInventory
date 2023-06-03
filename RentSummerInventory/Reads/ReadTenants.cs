using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entity;
using Repository;
using Repository.Provider;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма Арендодателей.
    /// </summary>
    public partial class ReadTenants : Form
    {
        /// <summary>
        /// Провайдер в таблицу "Арендодателя".
        /// </summary>
        private TenantLinqProvider Repository { get; }

        /// <summary>
        /// Форма, в которой произошел вызов.
        /// </summary>
        private MainForm MainForm { get; }

        public ReadTenants(MainForm form)
        {
            InitializeComponent();

            dataGridView_Tenants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Tenants.Font = new Font("Microsoft Sans Serif", 12);

            MainForm = form;
            var heads = new[]
            {
                "Id", "ФИО", "Возраст", "Пол", "Район"
            };

            foreach (var head in heads)
            {
                dataGridView_Tenants.Columns.Add(head, head);
            }

            dataGridView_Tenants.Columns[0].Width = 50;

            Repository = Service.GetProviderTenant();
            var tenants = Repository.GetTenants();

            foreach (var tenant in tenants)
            {
                dataGridView_Tenants.Rows.Add(tenant.TenantId, tenant.Fio, tenant.Age, tenant.Gender,
                    tenant.Region.NameRegion);
            }
        }

        #region Формы для чтения

        private void toolStrip_ReadInventory_Click(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            Close();
        }

        private void toolStrip_ReadRents_Click(object sender, EventArgs e)
        {
            var rents = new ReadRents(MainForm);
            rents.Visible = true;
            Close();
        }

        private void toolStrip_ReadBooking_Click(object sender, EventArgs e)
        {
            var rents = new ReadBooking(MainForm);
            rents.Visible = true;
            Close();
        }

        #endregion


        /// <summary>
        /// Кнопка сохарнения обновленных данных.
        /// </summary>
        private void button_Save_Click(object sender, EventArgs e)
        {
            var tenants = (from DataGridViewRow row in dataGridView_Tenants.SelectedRows
                select new Tenant
                {
                    TenantId = (int)dataGridView_Tenants.Rows[row.Index].Cells[0].Value,
                    Fio = (string)dataGridView_Tenants.Rows[row.Index].Cells[1].Value,
                    Age = (int)dataGridView_Tenants.Rows[row.Index].Cells[2].Value,
                    Gender = (char)dataGridView_Tenants.Rows[row.Index].Cells[3].Value
                }).ToList();

            Repository.UpdateTenant(tenants);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}