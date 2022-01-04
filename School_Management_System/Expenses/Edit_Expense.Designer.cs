namespace School_Management_System.Expenses
{
    partial class Edit_Expense
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
            this.AddExpense = new System.Windows.Forms.Button();
            this.lblexp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpenseDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseAmount = new System.Windows.Forms.TextBox();
            this.ExpenseType = new System.Windows.Forms.ComboBox();
            this.ExpenseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddExpense
            // 
            this.AddExpense.BackColor = System.Drawing.Color.SteelBlue;
            this.AddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense.ForeColor = System.Drawing.Color.White;
            this.AddExpense.Location = new System.Drawing.Point(222, 260);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(200, 52);
            this.AddExpense.TabIndex = 21;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.UseVisualStyleBackColor = false;
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.lblexp.Location = new System.Drawing.Point(223, 15);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(199, 25);
            this.lblexp.TabIndex = 20;
            this.lblexp.Text = "Add New Expense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label5.Location = new System.Drawing.Point(35, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descripition:";
            // 
            // ExpenseDescription
            // 
            this.ExpenseDescription.Location = new System.Drawing.Point(143, 144);
            this.ExpenseDescription.Name = "ExpenseDescription";
            this.ExpenseDescription.Size = new System.Drawing.Size(446, 96);
            this.ExpenseDescription.TabIndex = 18;
            this.ExpenseDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(88, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date:";
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpenseDate.Location = new System.Drawing.Point(143, 105);
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.Size = new System.Drawing.Size(177, 20);
            this.ExpenseDate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(331, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(344, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.Location = new System.Drawing.Point(412, 104);
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.Size = new System.Drawing.Size(177, 20);
            this.ExpenseAmount.TabIndex = 11;
            // 
            // ExpenseType
            // 
            this.ExpenseType.FormattingEnabled = true;
            this.ExpenseType.Items.AddRange(new object[] {
            "Basic",
            "Utility",
            "Maintenance",
            "Other"});
            this.ExpenseType.Location = new System.Drawing.Point(143, 64);
            this.ExpenseType.Name = "ExpenseType";
            this.ExpenseType.Size = new System.Drawing.Size(177, 21);
            this.ExpenseType.TabIndex = 13;
            // 
            // ExpenseName
            // 
            this.ExpenseName.Location = new System.Drawing.Point(412, 64);
            this.ExpenseName.Name = "ExpenseName";
            this.ExpenseName.Size = new System.Drawing.Size(177, 20);
            this.ExpenseName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Expenses Type:";
            // 
            // Edit_Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 337);
            this.Controls.Add(this.AddExpense);
            this.Controls.Add(this.lblexp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExpenseDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExpenseDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpenseAmount);
            this.Controls.Add(this.ExpenseType);
            this.Controls.Add(this.ExpenseName);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Expense";
            this.Text = "Edit_Expense";
            this.Load += new System.EventHandler(this.Edit_Expense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.Label lblexp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ExpenseDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ExpenseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpenseAmount;
        private System.Windows.Forms.ComboBox ExpenseType;
        private System.Windows.Forms.TextBox ExpenseName;
        private System.Windows.Forms.Label label1;
    }
}