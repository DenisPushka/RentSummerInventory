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
    public partial class AddRent : Form
    {
        /// <summary>
        /// Дата и время начала проката. 
        /// </summary>
        private DateTime _dateTimeStart;

        /// <summary>
        /// Дата и время окончания проката.
        /// </summary>
        private DateTime _dateTimeEnd;

        /// <summary>
        /// Текущая дата.
        /// </summary>
        private DateTime _dateNow = DateTime.Now;

        /// <summary>
        /// Главная форма.
        /// </summary>
        private MainForm Form { get; }

        public AddRent(MainForm form)
        {
            InitializeComponent();

            Form = form;
            dataGridView_Inventories.AutoSizeColumnsMode =
                dataGridView_Tenants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Inventories.Font = dataGridView_Tenants.Font = new Font("Microsoft Sans Serif", 12);

            var heads = new[]
            {
                "Id", "Группа", "Категория товаров", "Навзание", "Цена за час", "Депозит", "В наличии"
            };

            foreach (var head in heads)
            {
                dataGridView_Inventories.Columns.Add(head, head);
            }

            dataGridView_Inventories.Columns[0].Width = 50;
            dataGridView_Inventories.Columns[6].Width = 50;

            heads = new[]
            {
                "Id", "ФИО", "Возраст"
            };

            foreach (var head in heads)
            {
                dataGridView_Tenants.Columns.Add(head, head);
            }

            dataGridView_Tenants.Columns[0].Width = 50;

            var inventories = Service.GetProviderInventory().GetInventories();

            foreach (var inventory in inventories)
            {
                dataGridView_Inventories.Rows.Add(inventory.InventoryId,
                    inventory.GroupInventory.NameGroup, inventory.SubcategoryInventory.NameSubcategoryInventory,
                    inventory.Name, inventory.PriceHour, inventory.PriceDeposit, inventory.InStoke);
            }

            var tenants = Service.GetProviderTenant().GetTenants();
            foreach (var tenant in tenants)
            {
                dataGridView_Tenants.Rows.Add(tenant.TenantId, tenant.Fio, tenant.Age);
            }
        }

        /// <summary>
        /// ОБработчик события нажатия на кнопку "Сохранить".
        /// </summary>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            var repositoryRent = Service.GetProviderRent();
            var tenant = 0;
            
            foreach (DataGridViewRow row in dataGridView_Tenants.SelectedRows)
            {
                tenant = (int)dataGridView_Tenants.Rows[row.Index].Cells[0].Value;
            }

            var inventories = new List<int>();
            SqlMoney sumDeposit = 0;
            foreach (DataGridViewRow row in dataGridView_Inventories.SelectedRows)
            {
                inventories.Add((int)dataGridView_Inventories.Rows[row.Index].Cells[0].Value);
                sumDeposit += SqlMoney.Parse(dataGridView_Inventories.Rows[row.Index].Cells[5].Value.ToString());
            }

            repositoryRent.AddRent(new Rent
            {
                TenantId = tenant,
                PriceRent = SqlMoney.Parse(label_Sum.Text),
                DateStart = _dateTimeStart,
                DateEnd = _dateTimeEnd,
                CountInventory = inventories.Count,
                AllPriceDeposit = sumDeposit,
                IsRent = DateTime.Now > _dateTimeStart
            }, inventories);

            button_Close_Click(sender, e);
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
        /// При выборе строки вычисляется сумма за аренду по выбранному товару и времени.
        /// </summary>
        private void dataGridView_Inventories_CellContentClick(object sender, EventArgs e)
        {
            var time = _dateTimeEnd.Subtract(_dateTimeStart).TotalHours;
            
            label_Sum.Text = dataGridView_Inventories
                .SelectedRows
                .Cast<DataGridViewRow>()
                .Sum(row =>
                    (int)(time * double.Parse(dataGridView_Inventories
                        .Rows[row.Index]
                        .Cells[4]
                        .Value
                        .ToString())))
                .ToString();
        }
        
        /// <summary>
        /// Задается дата начала аренды.
        /// </summary>
        private void textBox_Start_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Start.Text.Length < 4)
                return;
            
            var timeStart = textBox_Start.Text.Split(':');
            _dateTimeStart = new DateTime(_dateNow.Year, _dateNow.Month, _dateNow.Day, int.Parse(timeStart[0]),
                int.Parse(timeStart[1]), 0);
        }

        /// <summary>
        /// Задается дата окончания аренды.
        /// </summary>
        private void textBox_End_TextChanged(object sender, EventArgs e)
        {
            if (textBox_End.Text.Length < 4)
                return;
            
            var timeEnd = textBox_End.Text.Split(':');
            _dateTimeEnd = new DateTime(_dateNow.Year, _dateNow.Month, _dateNow.Day, int.Parse(timeEnd[0]),
                int.Parse(timeEnd[1]), 0);
        }
    }
}