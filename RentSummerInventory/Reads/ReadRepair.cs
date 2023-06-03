using System;
using System.Drawing;
using System.Windows.Forms;
using Repository;

namespace RentSummerInventory
{
    public partial class ReadRepair : Form
    {
        /// <summary>
        /// Форма, в которой произошел вызов.
        /// </summary>
        private MainForm MainForm { get; }
        
        public ReadRepair(MainForm form)
        {
            InitializeComponent();
            dataGridView_repair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_repair.Font = new Font("Microsoft Sans Serif", 12);

            MainForm = form;
            var heads = new[]
            {
                "Навзание инвентаря", "Компания", "Телефон"
            };

            foreach (var head in heads)
            {
                dataGridView_repair.Columns.Add(head, head);
            }

            var restores = Service.GetProviderSupportiveQuery().GetRepair();

            foreach (var restore in restores)
            {
                dataGridView_repair.Rows.Add(restore.Inventory.Name, restore.Company.NameCompany, 
                    string.Concat(restore.Company.Phone));
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            Close();
        }
    }
}