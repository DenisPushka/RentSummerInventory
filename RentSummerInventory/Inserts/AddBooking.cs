using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entity;
using Repository;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма добавления бронирования.
    /// </summary>
    public partial class AddBooking : Form
    {
        /// <summary>
        /// Главная форма.
        /// </summary>
        private MainForm Form { get; }

        public AddBooking(MainForm form)
        {
            InitializeComponent();

            Form = form;
            dataGridView_InventoryNewBooking.AutoSizeColumnsMode = dataGridView_TenantsNewBooking.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_InventoryNewBooking.Font =
                dataGridView_TenantsNewBooking.Font = new Font("Microsoft Sans Serif", 12);

            var heads = new[]
            {
                "Id", "Группа", "Категория товаров", "Навзание", "Цена за час", "Депозит", "В наличии"
            };

            foreach (var head in heads)
            {
                dataGridView_InventoryNewBooking.Columns.Add(head, head);
            }

            dataGridView_InventoryNewBooking.Columns[0].Width = 50;
            dataGridView_InventoryNewBooking.Columns[6].Width = 50;

            heads = new[]
            {
                "Id", "ФИО", "Возраст"
            };

            foreach (var head in heads)
            {
                dataGridView_TenantsNewBooking.Columns.Add(head, head);
            }

            dataGridView_TenantsNewBooking.Columns[0].Width = 50;

            var inventories = Service.GetProviderInventory().GetInventories();

            foreach (var inventory in inventories)
            {
                dataGridView_InventoryNewBooking.Rows.Add(inventory.InventoryId,
                    inventory.GroupInventory.NameGroup, inventory.SubcategoryInventory.NameSubcategoryInventory,
                    inventory.Name, inventory.PriceHour, inventory.PriceDeposit, inventory.InStoke);
            }

            var tenants = Service.GetProviderTenant().GetTenants();
            foreach (var tenant in tenants)
            {
                dataGridView_TenantsNewBooking.Rows.Add(tenant.TenantId, tenant.Fio, tenant.Age);
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Сохранить".
        /// </summary>
        private void button_ok_Click(object sender, EventArgs e)
        {
            var tenantId = (int)dataGridView_TenantsNewBooking
                .Rows[dataGridView_TenantsNewBooking.SelectedRows[0].Index]
                .Cells[0].Value;

            var inventories =
            (
                from DataGridViewRow row in dataGridView_InventoryNewBooking.SelectedRows
                select (int)dataGridView_InventoryNewBooking.Rows[row.Index].Cells[0].Value
            ).ToList();


            Service.GetProviderBooking().AddBooking(new Booking
            {
                TenantId = tenantId,
                DateEnd = dateTime_Start.Value.Date
            }, inventories);
            Close();
            Form.Visible = true;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Закрыть".
        /// </summary>
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
            Form.Visible = true;
        }
    }
}