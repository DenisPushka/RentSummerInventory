using System.ComponentModel;

namespace RentSummerInventory
{
    partial class AddBooking
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_Cose = new System.Windows.Forms.Button();
            this.dateTime_Start = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_TenantsNewBooking = new System.Windows.Forms.DataGridView();
            this.dataGridView_InventoryNewBooking = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TenantsNewBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InventoryNewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(248, 600);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "Сохранить";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_Cose
            // 
            this.button_Cose.Location = new System.Drawing.Point(329, 600);
            this.button_Cose.Name = "button_Cose";
            this.button_Cose.Size = new System.Drawing.Size(75, 23);
            this.button_Cose.TabIndex = 3;
            this.button_Cose.Text = "Закрыть";
            this.button_Cose.UseVisualStyleBackColor = true;
            this.button_Cose.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // dateTime_Start
            // 
            this.dateTime_Start.Location = new System.Drawing.Point(12, 599);
            this.dateTime_Start.Name = "dateTime_Start";
            this.dateTime_Start.Size = new System.Drawing.Size(230, 20);
            this.dateTime_Start.TabIndex = 4;
            // 
            // dataGridView_TenantsNewBooking
            // 
            this.dataGridView_TenantsNewBooking.AllowUserToAddRows = false;
            this.dataGridView_TenantsNewBooking.AllowUserToDeleteRows = false;
            this.dataGridView_TenantsNewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TenantsNewBooking.Location = new System.Drawing.Point(789, 35);
            this.dataGridView_TenantsNewBooking.Name = "dataGridView_TenantsNewBooking";
            this.dataGridView_TenantsNewBooking.ReadOnly = true;
            this.dataGridView_TenantsNewBooking.Size = new System.Drawing.Size(483, 558);
            this.dataGridView_TenantsNewBooking.TabIndex = 6;
            // 
            // dataGridView_InventoryNewBooking
            // 
            this.dataGridView_InventoryNewBooking.AllowUserToAddRows = false;
            this.dataGridView_InventoryNewBooking.AllowUserToDeleteRows = false;
            this.dataGridView_InventoryNewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InventoryNewBooking.Location = new System.Drawing.Point(12, 35);
            this.dataGridView_InventoryNewBooking.Name = "dataGridView_InventoryNewBooking";
            this.dataGridView_InventoryNewBooking.ReadOnly = true;
            this.dataGridView_InventoryNewBooking.Size = new System.Drawing.Size(771, 558);
            this.dataGridView_InventoryNewBooking.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Инвентарь";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(789, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Арендаторы";
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_TenantsNewBooking);
            this.Controls.Add(this.dataGridView_InventoryNewBooking);
            this.Controls.Add(this.dateTime_Start);
            this.Controls.Add(this.button_Cose);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая бронь";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TenantsNewBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InventoryNewBooking)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView_InventoryNewBooking;

        private System.Windows.Forms.DataGridView dataGridView_TenantsNewBooking;

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_Cose;
        private System.Windows.Forms.DateTimePicker dateTime_Start;
    }
}