using System.ComponentModel;

namespace RentSummerInventory
{
    partial class AddRent
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
            this.dataGridView_Inventories = new System.Windows.Forms.DataGridView();
            this.dataGridView_Tenants = new System.Windows.Forms.DataGridView();
            this.Button_Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.textBox_End = new System.Windows.Forms.TextBox();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.label_TimeEnd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tenants)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Inventories
            // 
            this.dataGridView_Inventories.AllowUserToAddRows = false;
            this.dataGridView_Inventories.AllowUserToDeleteRows = false;
            this.dataGridView_Inventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inventories.Location = new System.Drawing.Point(12, 40);
            this.dataGridView_Inventories.Name = "dataGridView_Inventories";
            this.dataGridView_Inventories.ReadOnly = true;
            this.dataGridView_Inventories.Size = new System.Drawing.Size(924, 524);
            this.dataGridView_Inventories.TabIndex = 0;
            this.dataGridView_Inventories.Click += new System.EventHandler(this.dataGridView_Inventories_CellContentClick);
            // 
            // dataGridView_Tenants
            // 
            this.dataGridView_Tenants.AllowUserToAddRows = false;
            this.dataGridView_Tenants.AllowUserToDeleteRows = false;
            this.dataGridView_Tenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tenants.Location = new System.Drawing.Point(942, 40);
            this.dataGridView_Tenants.Name = "dataGridView_Tenants";
            this.dataGridView_Tenants.ReadOnly = true;
            this.dataGridView_Tenants.Size = new System.Drawing.Size(530, 524);
            this.dataGridView_Tenants.TabIndex = 1;
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Save.Location = new System.Drawing.Point(1213, 624);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(125, 31);
            this.Button_Save.TabIndex = 2;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1354, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(938, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Арендаторы";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Инвентарь";
            // 
            // textBox_Start
            // 
            this.textBox_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Start.Location = new System.Drawing.Point(812, 584);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(124, 29);
            this.textBox_Start.TabIndex = 6;
            this.textBox_Start.TextChanged += new System.EventHandler(this.textBox_Start_TextChanged);
            // 
            // textBox_End
            // 
            this.textBox_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_End.Location = new System.Drawing.Point(812, 620);
            this.textBox_End.Name = "textBox_End";
            this.textBox_End.Size = new System.Drawing.Size(124, 29);
            this.textBox_End.TabIndex = 7;
            this.textBox_End.TextChanged += new System.EventHandler(this.textBox_End_TextChanged);
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeStart.Location = new System.Drawing.Point(572, 589);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(201, 24);
            this.label_TimeStart.TabIndex = 8;
            this.label_TimeStart.Text = "Время начала (чч:мм)";
            // 
            // label_TimeEnd
            // 
            this.label_TimeEnd.AutoSize = true;
            this.label_TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeEnd.Location = new System.Drawing.Point(572, 623);
            this.label_TimeEnd.Name = "label_TimeEnd";
            this.label_TimeEnd.Size = new System.Drawing.Size(234, 24);
            this.label_TimeEnd.TabIndex = 9;
            this.label_TimeEnd.Text = "Время окончания (чч:мм)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Итого: ";
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sum.Location = new System.Drawing.Point(96, 584);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(0, 25);
            this.label_Sum.TabIndex = 11;
            // 
            // AddRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.label_Sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_TimeEnd);
            this.Controls.Add(this.label_TimeStart);
            this.Controls.Add(this.textBox_End);
            this.Controls.Add(this.textBox_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.dataGridView_Tenants);
            this.Controls.Add(this.dataGridView_Inventories);
            this.Name = "AddRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание аренды";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_Start;

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView_Inventories;

        private System.Windows.Forms.DataGridView dataGridView_Tenants;

        #endregion

        private System.Windows.Forms.TextBox textBox_End;
        private System.Windows.Forms.Label label_TimeStart;
        private System.Windows.Forms.Label label_TimeEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Sum;
    }
}