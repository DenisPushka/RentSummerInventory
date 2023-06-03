﻿using System.ComponentModel;

namespace RentSummerInventory
{
    partial class ReadBooking
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
            this.dataGridView_Boking = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Inventory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Rent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Tenants = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_AddInventory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddTenants = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddRent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddBooking = new System.Windows.Forms.ToolStripTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Boking)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Boking
            // 
            this.dataGridView_Boking.AllowUserToAddRows = false;
            this.dataGridView_Boking.AllowUserToDeleteRows = false;
            this.dataGridView_Boking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Boking.Location = new System.Drawing.Point(12, 50);
            this.dataGridView_Boking.Name = "dataGridView_Boking";
            this.dataGridView_Boking.Size = new System.Drawing.Size(1430, 604);
            this.dataGridView_Boking.TabIndex = 0;
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
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStrip_Inventory, this.toolStripSeparator1, this.toolStrip_Rent, this.toolStripSeparator2, this.toolStrip_Tenants });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem1.Text = "Другие окна";
            // 
            // toolStrip_Inventory
            // 
            this.toolStrip_Inventory.Name = "toolStrip_Inventory";
            this.toolStrip_Inventory.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_Inventory.Text = "Инвентарь";
            this.toolStrip_Inventory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStrip_Inventory.Click += new System.EventHandler(this.toolStrip_Inventory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_Rent
            // 
            this.toolStrip_Rent.Name = "toolStrip_Rent";
            this.toolStrip_Rent.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_Rent.Text = "Аренда";
            this.toolStrip_Rent.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStrip_Rent.Click += new System.EventHandler(this.toolStrip_Rent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_Tenants
            // 
            this.toolStrip_Tenants.Name = "toolStrip_Tenants";
            this.toolStrip_Tenants.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_Tenants.Text = "Арендодатели";
            this.toolStrip_Tenants.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStrip_Tenants.Click += new System.EventHandler(this.toolStrip_Tenants_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStrip_AddInventory, this.toolStripSeparator3, this.toolStrip_AddTenants, this.toolStripSeparator4, this.toolStrip_AddRent, this.toolStripSeparator5, this.toolStrip_AddBooking });
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem2.Text = "Добаить";
            // 
            // toolStrip_AddInventory
            // 
            this.toolStrip_AddInventory.Name = "toolStrip_AddInventory";
            this.toolStrip_AddInventory.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddInventory.Text = "Инвентарь";
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
            this.toolStrip_AddTenants.Text = "Арендодатель";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_AddRent
            // 
            this.toolStrip_AddRent.Name = "toolStrip_AddRent";
            this.toolStrip_AddRent.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddRent.Text = "Аренда";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStrip_AddBooking
            // 
            this.toolStrip_AddBooking.Name = "toolStrip_AddBooking";
            this.toolStrip_AddBooking.Size = new System.Drawing.Size(100, 23);
            this.toolStrip_AddBooking.Text = "Бронивароние";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1311, 1);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(131, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // ReadBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 661);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView_Boking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReadBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Boking)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddBooking;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddRent;
        private System.Windows.Forms.Button button_Save;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddTenants;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripTextBox toolStrip_AddInventory;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripTextBox toolStrip_Tenants;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripTextBox toolStrip_Rent;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripTextBox toolStrip_Inventory;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.DataGridView dataGridView_Boking;

        #endregion
    }
}