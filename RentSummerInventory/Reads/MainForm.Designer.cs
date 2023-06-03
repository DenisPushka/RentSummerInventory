namespace RentSummerInventory
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_OtherWindowTenants = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_OtherWindowRents = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_OtherWindowBookings = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_OtherWindowRepair = new System.Windows.Forms.ToolStripTextBox();
            this.Tools_AddWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_AddWindowRent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_AddWindowBooking = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_AddWindowInventory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_AddWindowTenant = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_AddWindowRepair = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView_Inventory = new System.Windows.Forms.DataGridView();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentSummerInventoryDataSet = new RentSummerInventory.RentSummerInventoryDataSet();
            this.inventoryTableAdapter = new RentSummerInventory.RentSummerInventoryDataSetTableAdapters.InventoryTableAdapter();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentSummerInventoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.Tools_AddWindow });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1454, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Tools_OtherWindowTenants, this.toolStripSeparator4, this.Tools_OtherWindowRents, this.toolStripSeparator5, this.Tools_OtherWindowBookings, this.toolStripSeparator6, this.Tools_OtherWindowRepair });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem1.Text = "Другие окна";
            // 
            // Tools_OtherWindowTenants
            // 
            this.Tools_OtherWindowTenants.Name = "Tools_OtherWindowTenants";
            this.Tools_OtherWindowTenants.Size = new System.Drawing.Size(100, 23);
            this.Tools_OtherWindowTenants.Text = "Арендодатели";
            this.Tools_OtherWindowTenants.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_OtherWindowTenants.Click += new System.EventHandler(this.Tools_OtherWindowTenants_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_OtherWindowRents
            // 
            this.Tools_OtherWindowRents.Name = "Tools_OtherWindowRents";
            this.Tools_OtherWindowRents.Size = new System.Drawing.Size(100, 23);
            this.Tools_OtherWindowRents.Text = "Аренда";
            this.Tools_OtherWindowRents.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_OtherWindowRents.Click += new System.EventHandler(this.Tools_OtherWindowRents_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_OtherWindowBookings
            // 
            this.Tools_OtherWindowBookings.Name = "Tools_OtherWindowBookings";
            this.Tools_OtherWindowBookings.Size = new System.Drawing.Size(100, 23);
            this.Tools_OtherWindowBookings.Text = "Брониварования";
            this.Tools_OtherWindowBookings.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_OtherWindowBookings.Click += new System.EventHandler(this.Tools_OtherWindowBookings_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_OtherWindowRepair
            // 
            this.Tools_OtherWindowRepair.Name = "Tools_OtherWindowRepair";
            this.Tools_OtherWindowRepair.Size = new System.Drawing.Size(100, 23);
            this.Tools_OtherWindowRepair.Text = "Ремонт";
            this.Tools_OtherWindowRepair.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_OtherWindowRepair.Click += new System.EventHandler(this.Tools_OtherWindowRepair_Click);
            // 
            // Tools_AddWindow
            // 
            this.Tools_AddWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Tools_AddWindowRent, this.toolStripSeparator1, this.Tools_AddWindowBooking, this.toolStripSeparator2, this.Tools_AddWindowInventory, this.toolStripSeparator3, this.Tools_AddWindowTenant, this.toolStripSeparator7, this.Tools_AddWindowRepair });
            this.Tools_AddWindow.Name = "Tools_AddWindow";
            this.Tools_AddWindow.Size = new System.Drawing.Size(71, 20);
            this.Tools_AddWindow.Text = "Добавить";
            // 
            // Tools_AddWindowRent
            // 
            this.Tools_AddWindowRent.Name = "Tools_AddWindowRent";
            this.Tools_AddWindowRent.Size = new System.Drawing.Size(100, 23);
            this.Tools_AddWindowRent.Text = "Аренда";
            this.Tools_AddWindowRent.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_AddWindowRent.Click += new System.EventHandler(this.Tools_AddWindowRent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_AddWindowBooking
            // 
            this.Tools_AddWindowBooking.Name = "Tools_AddWindowBooking";
            this.Tools_AddWindowBooking.Size = new System.Drawing.Size(100, 23);
            this.Tools_AddWindowBooking.Text = "Бронь";
            this.Tools_AddWindowBooking.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_AddWindowBooking.Click += new System.EventHandler(this.Tools_AddWindowBooking_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_AddWindowInventory
            // 
            this.Tools_AddWindowInventory.Name = "Tools_AddWindowInventory";
            this.Tools_AddWindowInventory.Size = new System.Drawing.Size(100, 23);
            this.Tools_AddWindowInventory.Text = "Инвентарь";
            this.Tools_AddWindowInventory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_AddWindowInventory.Click += new System.EventHandler(this.Tools_AddWindowInventory_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_AddWindowTenant
            // 
            this.Tools_AddWindowTenant.Name = "Tools_AddWindowTenant";
            this.Tools_AddWindowTenant.Size = new System.Drawing.Size(100, 23);
            this.Tools_AddWindowTenant.Text = "Арендодатель";
            this.Tools_AddWindowTenant.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_AddWindowTenant.Click += new System.EventHandler(this.Tools_AddWindowTenant_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(157, 6);
            // 
            // Tools_AddWindowRepair
            // 
            this.Tools_AddWindowRepair.Name = "Tools_AddWindowRepair";
            this.Tools_AddWindowRepair.Size = new System.Drawing.Size(100, 23);
            this.Tools_AddWindowRepair.Text = "Ремонт";
            this.Tools_AddWindowRepair.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tools_AddWindowRepair.Click += new System.EventHandler(this.Tools_AddWindowRepair_Click);
            // 
            // dataGridView_Inventory
            // 
            this.dataGridView_Inventory.AllowUserToAddRows = false;
            this.dataGridView_Inventory.AllowUserToDeleteRows = false;
            this.dataGridView_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_Inventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inventory.Location = new System.Drawing.Point(12, 27);
            this.dataGridView_Inventory.Name = "dataGridView_Inventory";
            this.dataGridView_Inventory.Size = new System.Drawing.Size(1430, 622);
            this.dataGridView_Inventory.TabIndex = 2;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.rentSummerInventoryDataSet;
            // 
            // rentSummerInventoryDataSet
            // 
            this.rentSummerInventoryDataSet.DataSetName = "RentSummerInventoryDataSet";
            this.rentSummerInventoryDataSet.Namespace = "http://tempuri.org/RentSummerInventoryDataSet.xsd";
            this.rentSummerInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(1339, 1);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(103, 23);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1020, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1230, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView_Inventory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спорт инвентарь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Close);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentSummerInventoryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripTextBox Tools_AddWindowRepair;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

        private System.Windows.Forms.ToolStripTextBox Tools_OtherWindowRepair;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ToolStripTextBox Tools_AddWindowRent;

        private System.Windows.Forms.Button button_Save;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tools_AddWindow;
        private System.Windows.Forms.DataGridView dataGridView_Inventory;
        private System.Windows.Forms.ToolStripTextBox Tools_AddWindowTenant;
        private System.Windows.Forms.ToolStripTextBox Tools_AddWindowBooking;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox Tools_AddWindowInventory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox Tools_OtherWindowTenants;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox Tools_OtherWindowRents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox Tools_OtherWindowBookings;
        private RentSummerInventoryDataSet rentSummerInventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private RentSummerInventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
    }
}