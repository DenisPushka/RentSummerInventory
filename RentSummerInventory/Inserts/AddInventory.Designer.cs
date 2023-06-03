using System.ComponentModel;

namespace RentSummerInventory
{
    partial class AddInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Add1 = new System.Windows.Forms.Label();
            this.label_Add2 = new System.Windows.Forms.Label();
            this.label_Add3 = new System.Windows.Forms.Label();
            this.domainUpDown_subcategory = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown_GroupInventory = new System.Windows.Forms.DomainUpDown();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.numericUpDown_PriceHour = new System.Windows.Forms.NumericUpDown();
            this.textBox_Add1 = new System.Windows.Forms.TextBox();
            this.textBox_Add2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Add3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.domainUpDown_Age = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown_Deposit = new System.Windows.Forms.NumericUpDown();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceHour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Deposit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подкатегория товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Группа товаров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость аренды за час:";
            // 
            // label_Add1
            // 
            this.label_Add1.AutoSize = true;
            this.label_Add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Add1.Location = new System.Drawing.Point(10, 253);
            this.label_Add1.Name = "label_Add1";
            this.label_Add1.Size = new System.Drawing.Size(20, 24);
            this.label_Add1.TabIndex = 4;
            this.label_Add1.Text = "1";
            // 
            // label_Add2
            // 
            this.label_Add2.AutoSize = true;
            this.label_Add2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Add2.Location = new System.Drawing.Point(10, 288);
            this.label_Add2.Name = "label_Add2";
            this.label_Add2.Size = new System.Drawing.Size(20, 24);
            this.label_Add2.TabIndex = 5;
            this.label_Add2.Text = "2";
            // 
            // label_Add3
            // 
            this.label_Add3.AutoSize = true;
            this.label_Add3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Add3.Location = new System.Drawing.Point(10, 323);
            this.label_Add3.Name = "label_Add3";
            this.label_Add3.Size = new System.Drawing.Size(20, 24);
            this.label_Add3.TabIndex = 6;
            this.label_Add3.Text = "3";
            // 
            // domainUpDown_subcategory
            // 
            this.domainUpDown_subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown_subcategory.Location = new System.Drawing.Point(289, 41);
            this.domainUpDown_subcategory.Name = "domainUpDown_subcategory";
            this.domainUpDown_subcategory.ReadOnly = true;
            this.domainUpDown_subcategory.Size = new System.Drawing.Size(408, 29);
            this.domainUpDown_subcategory.TabIndex = 9;
            this.domainUpDown_subcategory.SelectedItemChanged += new System.EventHandler(this.domainUpDown_subcategory_SelectedItemChanged);
            // 
            // domainUpDown_GroupInventory
            // 
            this.domainUpDown_GroupInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown_GroupInventory.Location = new System.Drawing.Point(289, 76);
            this.domainUpDown_GroupInventory.Name = "domainUpDown_GroupInventory";
            this.domainUpDown_GroupInventory.ReadOnly = true;
            this.domainUpDown_GroupInventory.Size = new System.Drawing.Size(408, 29);
            this.domainUpDown_GroupInventory.TabIndex = 10;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(289, 111);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(408, 29);
            this.textBox_Name.TabIndex = 11;
            // 
            // numericUpDown_PriceHour
            // 
            this.numericUpDown_PriceHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_PriceHour.Location = new System.Drawing.Point(289, 146);
            this.numericUpDown_PriceHour.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_PriceHour.Name = "numericUpDown_PriceHour";
            this.numericUpDown_PriceHour.Size = new System.Drawing.Size(408, 29);
            this.numericUpDown_PriceHour.TabIndex = 12;
            // 
            // textBox_Add1
            // 
            this.textBox_Add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Add1.Location = new System.Drawing.Point(289, 254);
            this.textBox_Add1.Name = "textBox_Add1";
            this.textBox_Add1.Size = new System.Drawing.Size(408, 29);
            this.textBox_Add1.TabIndex = 13;
            // 
            // textBox_Add2
            // 
            this.textBox_Add2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Add2.Location = new System.Drawing.Point(289, 289);
            this.textBox_Add2.Name = "textBox_Add2";
            this.textBox_Add2.Size = new System.Drawing.Size(408, 29);
            this.textBox_Add2.TabIndex = 14;
            // 
            // textBox_Add3
            // 
            this.textBox_Add3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Add3.Location = new System.Drawing.Point(289, 324);
            this.textBox_Add3.Name = "textBox_Add3";
            this.textBox_Add3.Size = new System.Drawing.Size(408, 29);
            this.textBox_Add3.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_Add1);
            this.groupBox1.Controls.Add(this.label_Add2);
            this.groupBox1.Controls.Add(this.label_Add3);
            this.groupBox1.Controls.Add(this.domainUpDown_subcategory);
            this.groupBox1.Controls.Add(this.domainUpDown_Age);
            this.groupBox1.Controls.Add(this.domainUpDown_GroupInventory);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.numericUpDown_Deposit);
            this.groupBox1.Controls.Add(this.numericUpDown_PriceHour);
            this.groupBox1.Controls.Add(this.textBox_Add1);
            this.groupBox1.Controls.Add(this.textBox_Add2);
            this.groupBox1.Controls.Add(this.textBox_Add3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 383);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание инвентаря";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Возрастная категория:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Депозит:";
            // 
            // domainUpDown_Age
            // 
            this.domainUpDown_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown_Age.Location = new System.Drawing.Point(289, 217);
            this.domainUpDown_Age.Name = "domainUpDown_Age";
            this.domainUpDown_Age.ReadOnly = true;
            this.domainUpDown_Age.Size = new System.Drawing.Size(408, 29);
            this.domainUpDown_Age.TabIndex = 10;
            // 
            // numericUpDown_Deposit
            // 
            this.numericUpDown_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_Deposit.Location = new System.Drawing.Point(289, 181);
            this.numericUpDown_Deposit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDown_Deposit.Name = "numericUpDown_Deposit";
            this.numericUpDown_Deposit.Size = new System.Drawing.Size(408, 29);
            this.numericUpDown_Deposit.TabIndex = 12;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(637, 444);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(81, 25);
            this.button_Exit.TabIndex = 17;
            this.button_Exit.Text = "Закрыть";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(524, 444);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(107, 25);
            this.button_Save.TabIndex = 17;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 481);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление инвентаря";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceHour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Deposit)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numericUpDown_Deposit;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.DomainUpDown domainUpDown_Age;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Save;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Add1;
        private System.Windows.Forms.Label label_Add2;
        private System.Windows.Forms.Label label_Add3;
        private System.Windows.Forms.DomainUpDown domainUpDown_subcategory;
        private System.Windows.Forms.DomainUpDown domainUpDown_GroupInventory;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.NumericUpDown numericUpDown_PriceHour;
        private System.Windows.Forms.TextBox textBox_Add1;
        private System.Windows.Forms.MaskedTextBox textBox_Add2;
        private System.Windows.Forms.TextBox textBox_Add3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}