using System.ComponentModel;

namespace RentSummerInventory
{
    partial class ReadTenants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridView_Tenants = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_ReadInventory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_ReadRents = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_ReadBooking = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_AddInventory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddTenants = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddBooking = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddRent = new System.Windows.Forms.ToolStripTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tenants)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Tenants
            // 
            this.dataGridView_Tenants.AllowUserToAddRows = false;
            this.dataGridView_Tenants.AllowUserToDeleteRows = false;
            this.dataGridView_Tenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tenants.Location = new System.Drawing.Point(12, 34);
            this.dataGridView_Tenants.Name = "dataGridView_Tenants";
            this.dataGridView_Tenants.Size = new System.Drawing.Size(1430, 615);
            this.dataGridView_Tenants.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.toolStripMenuItem2 });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1454, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStrip_ReadInventory, this.toolStripSeparator1, this.toolStrip_ReadRents, this.toolStripSeparator2, this.toolStrip_ReadBooking });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem1.Text = "Другие окна";
            // 
            // toolStrip_ReadInventory
            // 
            this.toolStrip_ReadInventory.Name = "toolStrip_ReadInventory";
            this.toolStrip_ReadInventory.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_ReadInventory.Text = "Инвентарь";
            this.toolStrip_ReadInventory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStrip_ReadInventory.Click += new System.EventHandler(this.toolStrip_ReadInventory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_ReadRents
            // 
            this.toolStrip_ReadRents.Name = "toolStrip_ReadRents";
            this.toolStrip_ReadRents.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_ReadRents.Text = "Аренда";
            this.toolStrip_ReadRents.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStrip_ReadRents.Click += new System.EventHandler(this.toolStrip_ReadRents_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_ReadBooking
            // 
            this.toolStrip_ReadBooking.Name = "toolStrip_ReadBooking";
            this.toolStrip_ReadBooking.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_ReadBooking.Text = "Бронирование";
            this.toolStrip_ReadBooking.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStrip_ReadBooking.Click += new System.EventHandler(this.toolStrip_ReadBooking_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStrip_AddInventory, this.toolStripSeparator3, this.toolStrip_AddTenants, this.toolStripSeparator4, this.toolStrip_AddBooking, this.toolStripSeparator5, this.toolStrip_AddRent });
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem2.Text = "Добавить";
            // 
            // toolStrip_AddInventory
            // 
            this.toolStrip_AddInventory.Name = "toolStrip_AddInventory";
            this.toolStrip_AddInventory.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddInventory.Text = "Инвентарь";
            this.toolStrip_AddInventory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_AddTenants
            // 
            this.toolStrip_AddTenants.Name = "toolStrip_AddTenants";
            this.toolStrip_AddTenants.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddTenants.Text = "Арендодателя";
            this.toolStrip_AddTenants.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_AddBooking
            // 
            this.toolStrip_AddBooking.Name = "toolStrip_AddBooking";
            this.toolStrip_AddBooking.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddBooking.Text = "Бронирование";
            this.toolStrip_AddBooking.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_AddRent
            // 
            this.toolStrip_AddRent.Name = "toolStrip_AddRent";
            this.toolStrip_AddRent.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddRent.Text = "Аренда";
            this.toolStrip_AddRent.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1313, 0);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(129, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(1232, 1);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1042, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ReadTenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 661);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView_Tenants);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReadTenants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadTenants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tenants)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddRent;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddBooking;
        private System.Windows.Forms.Button button_Save;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddTenants;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddInventory;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripTextBox toolStrip_ReadBooking;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripTextBox toolStrip_ReadRents;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripTextBox toolStrip_ReadInventory;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.DataGridView dataGridView_Tenants;

        #endregion
    }
}