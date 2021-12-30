namespace School_Management_System.Fee
{
    partial class Add_Fee
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
            this.feeStd_lbl = new System.Windows.Forms.Label();
            this.feeLastMonthCharges_txtbox = new System.Windows.Forms.TextBox();
            this.feeClassId_comboBox = new System.Windows.Forms.ComboBox();
            this.feeClassId_lbl = new System.Windows.Forms.Label();
            this.feeStd_comboBox = new System.Windows.Forms.ComboBox();
            this.feeMoth_lbl = new System.Windows.Forms.Label();
            this.feeLastMonthCharges_lbl = new System.Windows.Forms.Label();
            this.feeDiscount_lbl = new System.Windows.Forms.Label();
            this.feeTotal_lbl = new System.Windows.Forms.Label();
            this.feeTotal_txtbox = new System.Windows.Forms.TextBox();
            this.feeDiscount_txtbox = new System.Windows.Forms.TextBox();
            this.feeSubTotal_txtbox = new System.Windows.Forms.TextBox();
            this.feePaid_lbl = new System.Windows.Forms.Label();
            this.feeSubTotal_lbl = new System.Windows.Forms.Label();
            this.feePaid_txtbox = new System.Windows.Forms.TextBox();
            this.feeRemaining_txtbox = new System.Windows.Forms.TextBox();
            this.feeRemaining_lbl = new System.Windows.Forms.Label();
            this.feeDate_txtbox = new System.Windows.Forms.DateTimePicker();
            this.feeDate_lbl = new System.Windows.Forms.Label();
            this.feeAdd_btn = new System.Windows.Forms.Button();
            this.lblfee = new System.Windows.Forms.Label();
            this.feeMonth_txtbox = new System.Windows.Forms.TextBox();
            this.generateFeeSlip_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feeStd_lbl
            // 
            this.feeStd_lbl.AutoSize = true;
            this.feeStd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeStd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeStd_lbl.Location = new System.Drawing.Point(393, 83);
            this.feeStd_lbl.Name = "feeStd_lbl";
            this.feeStd_lbl.Size = new System.Drawing.Size(154, 20);
            this.feeStd_lbl.TabIndex = 0;
            this.feeStd_lbl.Text = "Student Name-ID:";
            // 
            // feeLastMonthCharges_txtbox
            // 
            this.feeLastMonthCharges_txtbox.Location = new System.Drawing.Point(556, 239);
            this.feeLastMonthCharges_txtbox.Name = "feeLastMonthCharges_txtbox";
            this.feeLastMonthCharges_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeLastMonthCharges_txtbox.TabIndex = 1;
            // 
            // feeClassId_comboBox
            // 
            this.feeClassId_comboBox.FormattingEnabled = true;
            this.feeClassId_comboBox.Location = new System.Drawing.Point(165, 82);
            this.feeClassId_comboBox.Name = "feeClassId_comboBox";
            this.feeClassId_comboBox.Size = new System.Drawing.Size(203, 28);
            this.feeClassId_comboBox.TabIndex = 2;
            this.feeClassId_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // feeClassId_lbl
            // 
            this.feeClassId_lbl.AutoSize = true;
            this.feeClassId_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeClassId_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeClassId_lbl.Location = new System.Drawing.Point(16, 90);
            this.feeClassId_lbl.Name = "feeClassId_lbl";
            this.feeClassId_lbl.Size = new System.Drawing.Size(134, 20);
            this.feeClassId_lbl.TabIndex = 4;
            this.feeClassId_lbl.Text = "Class Name-ID:";
            // 
            // feeStd_comboBox
            // 
            this.feeStd_comboBox.FormattingEnabled = true;
            this.feeStd_comboBox.Location = new System.Drawing.Point(556, 82);
            this.feeStd_comboBox.Name = "feeStd_comboBox";
            this.feeStd_comboBox.Size = new System.Drawing.Size(203, 28);
            this.feeStd_comboBox.TabIndex = 2;
            // 
            // feeMoth_lbl
            // 
            this.feeMoth_lbl.AutoSize = true;
            this.feeMoth_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeMoth_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeMoth_lbl.Location = new System.Drawing.Point(92, 137);
            this.feeMoth_lbl.Name = "feeMoth_lbl";
            this.feeMoth_lbl.Size = new System.Drawing.Size(64, 20);
            this.feeMoth_lbl.TabIndex = 5;
            this.feeMoth_lbl.Text = "Month:";
            // 
            // feeLastMonthCharges_lbl
            // 
            this.feeLastMonthCharges_lbl.AutoSize = true;
            this.feeLastMonthCharges_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLastMonthCharges_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeLastMonthCharges_lbl.Location = new System.Drawing.Point(375, 239);
            this.feeLastMonthCharges_lbl.Name = "feeLastMonthCharges_lbl";
            this.feeLastMonthCharges_lbl.Size = new System.Drawing.Size(176, 20);
            this.feeLastMonthCharges_lbl.TabIndex = 6;
            this.feeLastMonthCharges_lbl.Text = "Last Month Charges:";
            // 
            // feeDiscount_lbl
            // 
            this.feeDiscount_lbl.AutoSize = true;
            this.feeDiscount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeDiscount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeDiscount_lbl.Location = new System.Drawing.Point(466, 196);
            this.feeDiscount_lbl.Name = "feeDiscount_lbl";
            this.feeDiscount_lbl.Size = new System.Drawing.Size(85, 20);
            this.feeDiscount_lbl.TabIndex = 7;
            this.feeDiscount_lbl.Text = "Discount:";
            // 
            // feeTotal_lbl
            // 
            this.feeTotal_lbl.AutoSize = true;
            this.feeTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeTotal_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeTotal_lbl.Location = new System.Drawing.Point(66, 187);
            this.feeTotal_lbl.Name = "feeTotal_lbl";
            this.feeTotal_lbl.Size = new System.Drawing.Size(90, 20);
            this.feeTotal_lbl.TabIndex = 8;
            this.feeTotal_lbl.Text = "Total Fee:";
            // 
            // feeTotal_txtbox
            // 
            this.feeTotal_txtbox.Location = new System.Drawing.Point(165, 184);
            this.feeTotal_txtbox.Name = "feeTotal_txtbox";
            this.feeTotal_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeTotal_txtbox.TabIndex = 1;
            // 
            // feeDiscount_txtbox
            // 
            this.feeDiscount_txtbox.Location = new System.Drawing.Point(556, 190);
            this.feeDiscount_txtbox.Name = "feeDiscount_txtbox";
            this.feeDiscount_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeDiscount_txtbox.TabIndex = 1;
            this.feeDiscount_txtbox.TextChanged += new System.EventHandler(this.feeDiscount_txtbox_TextChanged);
            // 
            // feeSubTotal_txtbox
            // 
            this.feeSubTotal_txtbox.Location = new System.Drawing.Point(165, 233);
            this.feeSubTotal_txtbox.Name = "feeSubTotal_txtbox";
            this.feeSubTotal_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeSubTotal_txtbox.TabIndex = 1;
            // 
            // feePaid_lbl
            // 
            this.feePaid_lbl.AutoSize = true;
            this.feePaid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feePaid_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feePaid_lbl.Location = new System.Drawing.Point(110, 299);
            this.feePaid_lbl.Name = "feePaid_lbl";
            this.feePaid_lbl.Size = new System.Drawing.Size(49, 20);
            this.feePaid_lbl.TabIndex = 7;
            this.feePaid_lbl.Text = "Paid:";
            // 
            // feeSubTotal_lbl
            // 
            this.feeSubTotal_lbl.AutoSize = true;
            this.feeSubTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeSubTotal_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeSubTotal_lbl.Location = new System.Drawing.Point(68, 236);
            this.feeSubTotal_lbl.Name = "feeSubTotal_lbl";
            this.feeSubTotal_lbl.Size = new System.Drawing.Size(91, 20);
            this.feeSubTotal_lbl.TabIndex = 8;
            this.feeSubTotal_lbl.Text = "Sub Total:";
            // 
            // feePaid_txtbox
            // 
            this.feePaid_txtbox.Location = new System.Drawing.Point(165, 293);
            this.feePaid_txtbox.Name = "feePaid_txtbox";
            this.feePaid_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feePaid_txtbox.TabIndex = 1;
            this.feePaid_txtbox.TextChanged += new System.EventHandler(this.feePaid_txtbox_TextChanged);
            // 
            // feeRemaining_txtbox
            // 
            this.feeRemaining_txtbox.Location = new System.Drawing.Point(557, 291);
            this.feeRemaining_txtbox.Name = "feeRemaining_txtbox";
            this.feeRemaining_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeRemaining_txtbox.TabIndex = 1;
            // 
            // feeRemaining_lbl
            // 
            this.feeRemaining_lbl.AutoSize = true;
            this.feeRemaining_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeRemaining_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeRemaining_lbl.Location = new System.Drawing.Point(456, 296);
            this.feeRemaining_lbl.Name = "feeRemaining_lbl";
            this.feeRemaining_lbl.Size = new System.Drawing.Size(95, 20);
            this.feeRemaining_lbl.TabIndex = 8;
            this.feeRemaining_lbl.Text = "Remaning:";
            // 
            // feeDate_txtbox
            // 
            this.feeDate_txtbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.feeDate_txtbox.Location = new System.Drawing.Point(556, 137);
            this.feeDate_txtbox.Name = "feeDate_txtbox";
            this.feeDate_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeDate_txtbox.TabIndex = 3;
            // 
            // feeDate_lbl
            // 
            this.feeDate_lbl.AutoSize = true;
            this.feeDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeDate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.feeDate_lbl.Location = new System.Drawing.Point(488, 143);
            this.feeDate_lbl.Name = "feeDate_lbl";
            this.feeDate_lbl.Size = new System.Drawing.Size(53, 20);
            this.feeDate_lbl.TabIndex = 5;
            this.feeDate_lbl.Text = "Date:";
            // 
            // feeAdd_btn
            // 
            this.feeAdd_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.feeAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feeAdd_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeAdd_btn.ForeColor = System.Drawing.Color.White;
            this.feeAdd_btn.Location = new System.Drawing.Point(284, 379);
            this.feeAdd_btn.Name = "feeAdd_btn";
            this.feeAdd_btn.Size = new System.Drawing.Size(257, 52);
            this.feeAdd_btn.TabIndex = 10;
            this.feeAdd_btn.Text = "Add Fee";
            this.feeAdd_btn.UseVisualStyleBackColor = false;
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.lblfee.Location = new System.Drawing.Point(285, 22);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(150, 25);
            this.lblfee.TabIndex = 11;
            this.lblfee.Text = "Add New Fee";
            // 
            // feeMonth_txtbox
            // 
            this.feeMonth_txtbox.Location = new System.Drawing.Point(165, 137);
            this.feeMonth_txtbox.Name = "feeMonth_txtbox";
            this.feeMonth_txtbox.Size = new System.Drawing.Size(203, 26);
            this.feeMonth_txtbox.TabIndex = 12;
            // 
            // generateFeeSlip_btn
            // 
            this.generateFeeSlip_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateFeeSlip_btn.Location = new System.Drawing.Point(604, 23);
            this.generateFeeSlip_btn.Name = "generateFeeSlip_btn";
            this.generateFeeSlip_btn.Size = new System.Drawing.Size(155, 35);
            this.generateFeeSlip_btn.TabIndex = 13;
            this.generateFeeSlip_btn.Text = "Generate Slip";
            this.generateFeeSlip_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.generateFeeSlip_btn);
            this.Controls.Add(this.feeMonth_txtbox);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.feeAdd_btn);
            this.Controls.Add(this.feeRemaining_lbl);
            this.Controls.Add(this.feeSubTotal_lbl);
            this.Controls.Add(this.feePaid_lbl);
            this.Controls.Add(this.feeTotal_lbl);
            this.Controls.Add(this.feeDiscount_lbl);
            this.Controls.Add(this.feeLastMonthCharges_lbl);
            this.Controls.Add(this.feeDate_lbl);
            this.Controls.Add(this.feeMoth_lbl);
            this.Controls.Add(this.feeDate_txtbox);
            this.Controls.Add(this.feeClassId_lbl);
            this.Controls.Add(this.feeRemaining_txtbox);
            this.Controls.Add(this.feeStd_comboBox);
            this.Controls.Add(this.feeSubTotal_txtbox);
            this.Controls.Add(this.feeClassId_comboBox);
            this.Controls.Add(this.feeTotal_txtbox);
            this.Controls.Add(this.feePaid_txtbox);
            this.Controls.Add(this.feeDiscount_txtbox);
            this.Controls.Add(this.feeLastMonthCharges_txtbox);
            this.Controls.Add(this.feeStd_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_Fee";
            this.Text = "Add_Fee";
            this.Load += new System.EventHandler(this.Add_Fee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feeStd_lbl;
        private System.Windows.Forms.TextBox feeLastMonthCharges_txtbox;
        private System.Windows.Forms.ComboBox feeClassId_comboBox;
        private System.Windows.Forms.Label feeClassId_lbl;
        private System.Windows.Forms.ComboBox feeStd_comboBox;
        private System.Windows.Forms.Label feeMoth_lbl;
        private System.Windows.Forms.Label feeLastMonthCharges_lbl;
        private System.Windows.Forms.Label feeDiscount_lbl;
        private System.Windows.Forms.Label feeTotal_lbl;
        private System.Windows.Forms.TextBox feeTotal_txtbox;
        private System.Windows.Forms.TextBox feeDiscount_txtbox;
        private System.Windows.Forms.TextBox feeSubTotal_txtbox;
        private System.Windows.Forms.Label feePaid_lbl;
        private System.Windows.Forms.Label feeSubTotal_lbl;
        private System.Windows.Forms.TextBox feePaid_txtbox;
        private System.Windows.Forms.TextBox feeRemaining_txtbox;
        private System.Windows.Forms.Label feeRemaining_lbl;
        private System.Windows.Forms.DateTimePicker feeDate_txtbox;
        private System.Windows.Forms.Label feeDate_lbl;
        private System.Windows.Forms.Button feeAdd_btn;
        private System.Windows.Forms.Label lblfee;
        private System.Windows.Forms.TextBox feeMonth_txtbox;
        private System.Windows.Forms.Button generateFeeSlip_btn;
    }
}