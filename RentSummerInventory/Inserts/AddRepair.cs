using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Repository;

namespace RentSummerInventory
{
    /// <summary>
    /// Форма для создания записи о ремонте.
    /// </summary>
    public partial class AddRepair : Form
    {
        /// <summary>
        /// Главная форма.
        /// </summary>
        private MainForm Form { get; }

        public AddRepair(MainForm form)
        {
            InitializeComponent();
            Form = form;
            dataGridView_Inventory.AutoSizeColumnsMode = dataGridView_Company.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Inventory.Font =
                dataGridView_Company.Font = new Font("Microsoft Sans Serif", 12);

            var heads = new[]
            {
                "Id", "Группа", "Категория товаров", "Навзание", "В наличии"
            };

            foreach (var head in heads)
            {
                dataGridView_Inventory.Columns.Add(head, head);
            }

            dataGridView_Inventory.Columns[0].Width = 50;
            dataGridView_Inventory.Columns[4].Width = 50;

            heads = new[]
            {
                "Id", "Название", "Телефон", "Адрес"
            };

            foreach (var head in heads)
            {
                dataGridView_Company.Columns.Add(head, head);
            }

            dataGridView_Company.Columns[0].Width = 50;

            var inventories = Service.GetProviderInventory().GetInventories();

            foreach (var inventory in inventories)
            {
                dataGridView_Inventory.Rows.Add(inventory.InventoryId,
                    inventory.GroupInventory.NameGroup, inventory.SubcategoryInventory.NameSubcategoryInventory,
                    inventory.Name, inventory.InStoke);
            }

            var companies = Service.GetProviderSupportiveQuery().GetCompany();
            foreach (var company in companies)
            {
                dataGridView_Company.Rows.Add(company.CompanyId, company.NameCompany,
                    company.Phone, string.Concat(company.Address.Street, ", ", company.Address.Home));
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Закрыть".
        /// </summary>
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
            Form.Visible = true;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Сохранить".
        /// </summary>
        private void button_Save_Click(object sender, EventArgs e)
        {
            var companyId = (int)dataGridView_Company
                .Rows[dataGridView_Company.SelectedRows[0].Index]
                .Cells[0].Value;

            var inventories =
            (
                from DataGridViewRow row in dataGridView_Inventory.SelectedRows
                select (int)dataGridView_Inventory.Rows[row.Index].Cells[0].Value
            ).ToList();

            Service.GetProviderSupportiveQuery().AddRepair(companyId, inventories, SqlMoney.Parse(textBox_Price.Text));
            Close();
            Form.Visible = true;
        }
    }
}