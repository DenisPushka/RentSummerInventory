using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entity;
using Repository;
using Repository.Provider;

namespace RentSummerInventory
{
    /// <summary>
    /// Главная форма. Учет инвенторя.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Провайдер в таблицу "Инвентаря".
        /// </summary>
        private InventoryLinqProvider Repository { get; }

        public MainForm()
        {
            InitializeComponent();
            dataGridView_Inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Inventory.Font = new Font("Microsoft Sans Serif", 12);

            var heads = new[]
            {
                "Id", "Категория товаров", "Группа", "Навзание", "Цена за час", "Депозит", "В наличии",
                "Возрастная категория"
            };

            foreach (var head in heads)
            {
                dataGridView_Inventory.Columns.Add(head, head);
            }

            dataGridView_Inventory.Columns[0].Width = 50;

            Repository = Service.GetProviderInventory();
            var inventories = Repository.GetInventories();
            UpdateSet(inventories);
        }

        /// <summary>
        /// Обновление таблицы.
        /// </summary>
        public void UpdateSet(List<Inventory> inventories)
        {
            dataGridView_Inventory.Rows.Clear();
            foreach (var inventory in inventories)
            {
                dataGridView_Inventory.Rows.Add(inventory.InventoryId,
                    inventory.SubcategoryInventory.NameSubcategoryInventory, inventory.GroupInventory.NameGroup,
                    inventory.Name, inventory.PriceHour, inventory.PriceDeposit, inventory.InStoke,
                    inventory.AgeCategory.NameCategory);
            }
        }

        /// <summary>
        /// Кнопка сохарнения обновленных данных.
        /// </summary>
        private void button_Save_Click(object sender, EventArgs e)
        {
            var inventories = (from DataGridViewRow row in dataGridView_Inventory.SelectedRows
                select new Inventory
                {
                    InventoryId = (int)dataGridView_Inventory.Rows[row.Index].Cells[0].Value,
                    Name = (string)dataGridView_Inventory.Rows[row.Index].Cells[3].Value,
                    PriceHour = SqlMoney.Parse(dataGridView_Inventory.Rows[row.Index].Cells[4].Value.ToString()),
                    PriceDeposit = SqlMoney.Parse(dataGridView_Inventory.Rows[row.Index].Cells[5].Value.ToString()),
                    InStoke = bool.Parse(dataGridView_Inventory.Rows[row.Index].Cells[6].Value.ToString())
                }).ToList();

            Repository.UpdateInventory(inventories);
        }

        #region Формы на чтение

        /// <summary>
        /// Открытие окна "Арендодатели".
        /// </summary>
        private void Tools_OtherWindowTenants_Click(object sender, EventArgs e)
        {
            var readTenants = new ReadTenants(this)
            {
                Visible = true
            };
            Visible = false;
        }

        /// <summary>
        /// Открытие окна "Аренда".
        /// </summary>
        private void Tools_OtherWindowRents_Click(object sender, EventArgs e)
        {
            var readRents = new ReadRents(this)
            {
                Visible = true
            };
            Visible = false;
        }

        /// <summary>
        /// Открытие окна "Бронирование".
        /// </summary>
        private void Tools_OtherWindowBookings_Click(object sender, EventArgs e)
        {
            var readBooking = new ReadBooking(this)
            {
                Visible = true
            };
            Visible = false;
        }
        
        private void Tools_OtherWindowRepair_Click(object sender, EventArgs e)
        {
            var readBooking = new ReadRepair(this)
            {
                Visible = true
            };
            Visible = false;
        }

        #endregion

        #region Формы добаввления

        private void Tools_AddWindowBooking_Click(object sender, EventArgs e)
        {
            Visible = false;
            var addBooking = new AddBooking(this)
            {
                Visible = true
            };
        }
        private void Tools_AddWindowRepair_Click(object sender, EventArgs e)
        {
            Visible = false;
            var addInventory = new AddRepair(this)
            {
                Visible = true
            };
        }

        private void Tools_AddWindowRent_Click(object sender, EventArgs e)
        {
            Visible = false;
            var addRent = new AddRent(this)
            {
                Visible = true
            };
        }

        private void Tools_AddWindowInventory_Click(object sender, EventArgs e)
        {
            Visible = false;
            var addInventory = new AddInventory(this)
            {
                Visible = true
            };
        }
        
        private void Tools_AddWindowTenant_Click(object sender, EventArgs e)
        {
            Visible = false;
            var registrationTenant = new RegistrationTenant(this)
            {
                Visible = true
            };
        }

        #endregion

        private void Form_Close(object sender, FormClosingEventArgs e) => Application.Exit();

        /// <summary>
        /// Обработчик события кнопки "Поиск".
        /// </summary>
        private void button_Search_Click(object sender, EventArgs e)
        {
            var textSearch = textBox1.Text;
            var subcategories = Service.GetProviderSupportiveQuery().GetSubcategoryInventories();

            UpdateSet(subcategories.Any(subcategory => subcategory.NameSubcategoryInventory.Equals(textSearch))
                ? Repository.GetInventoriesForCategories(textSearch)
                : Repository.GetInventoryForName(textSearch));
        }
    }
}