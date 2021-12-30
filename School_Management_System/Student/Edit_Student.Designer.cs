
namespace School_Management_System.Student
{
    partial class Edit_Student
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
            this.stdAdmissionError_lbl = new System.Windows.Forms.Label();
            this.stdClassError_lbl = new System.Windows.Forms.Label();
            this.stdFatherError_lbl = new System.Windows.Forms.Label();
            this.stdNameError_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stdPhone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stdEdit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stdAdmission_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.stdDob_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdClassEdit_comboBox = new System.Windows.Forms.ComboBox();
            this.lblstd = new System.Windows.Forms.Label();
            this.stdFatherEdit_comboBox = new System.Windows.Forms.ComboBox();
            this.stdAddress_txtbox = new System.Windows.Forms.TextBox();
            this.stdStatus_textBox = new System.Windows.Forms.TextBox();
            this.stdName_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentId_txtbox = new System.Windows.Forms.TextBox();
            this.studentId_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stdAdmissionError_lbl
            // 
            this.stdAdmissionError_lbl.AutoSize = true;
            this.stdAdmissionError_lbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdAdmissionError_lbl.ForeColor = System.Drawing.Color.Red;
            this.stdAdmissionError_lbl.Location = new System.Drawing.Point(514, 214);
            this.stdAdmissionError_lbl.Name = "stdAdmissionError_lbl";
            this.stdAdmissionError_lbl.Size = new System.Drawing.Size(201, 21);
            this.stdAdmissionError_lbl.TabIndex = 38;
            this.stdAdmissionError_lbl.Text = "Admission date is missing";
            this.stdAdmissionError_lbl.Visible = false;
            // 
            // stdClassError_lbl
            // 
            this.stdClassError_lbl.AutoSize = true;
            this.stdClassError_lbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdClassError_lbl.ForeColor = System.Drawing.Color.Red;
            this.stdClassError_lbl.Location = new System.Drawing.Point(139, 199);
            this.stdClassError_lbl.Name = "stdClassError_lbl";
            this.stdClassError_lbl.Size = new System.Drawing.Size(170, 21);
            this.stdClassError_lbl.TabIndex = 37;
            this.stdClassError_lbl.Text = "Class name is missing";
            this.stdClassError_lbl.Visible = false;
            // 
            // stdFatherError_lbl
            // 
            this.stdFatherError_lbl.AutoSize = true;
            this.stdFatherError_lbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdFatherError_lbl.ForeColor = System.Drawing.Color.Red;
            this.stdFatherError_lbl.Location = new System.Drawing.Point(524, 133);
            this.stdFatherError_lbl.Name = "stdFatherError_lbl";
            this.stdFatherError_lbl.Size = new System.Drawing.Size(182, 21);
            this.stdFatherError_lbl.TabIndex = 36;
            this.stdFatherError_lbl.Text = "Father name is missing";
            this.stdFatherError_lbl.Visible = false;
            // 
            // stdNameError_lbl
            // 
            this.stdNameError_lbl.AutoSize = true;
            this.stdNameError_lbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdNameError_lbl.ForeColor = System.Drawing.Color.Red;
            this.stdNameError_lbl.Location = new System.Drawing.Point(139, 133);
            this.stdNameError_lbl.Name = "stdNameError_lbl";
            this.stdNameError_lbl.Size = new System.Drawing.Size(194, 21);
            this.stdNameError_lbl.TabIndex = 35;
            this.stdNameError_lbl.Text = "Student name is missing";
            this.stdNameError_lbl.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(775, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stdPhone_maskedTextBox
            // 
            this.stdPhone_maskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdPhone_maskedTextBox.Location = new System.Drawing.Point(518, 317);
            this.stdPhone_maskedTextBox.Mask = "0000-0000000";
            this.stdPhone_maskedTextBox.Name = "stdPhone_maskedTextBox";
            this.stdPhone_maskedTextBox.Size = new System.Drawing.Size(185, 27);
            this.stdPhone_maskedTextBox.TabIndex = 33;
            // 
            // stdEdit_btn
            // 
            this.stdEdit_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.stdEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stdEdit_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdEdit_btn.ForeColor = System.Drawing.Color.White;
            this.stdEdit_btn.Location = new System.Drawing.Point(312, 386);
            this.stdEdit_btn.Name = "stdEdit_btn";
            this.stdEdit_btn.Size = new System.Drawing.Size(200, 52);
            this.stdEdit_btn.TabIndex = 32;
            this.stdEdit_btn.Text = "Edit Student";
            this.stdEdit_btn.UseVisualStyleBackColor = false;
            this.stdEdit_btn.Click += new System.EventHandler(this.stdEdit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(765, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 165);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label7.Location = new System.Drawing.Point(373, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Admission Date:*";
            // 
            // stdAdmission_dateTimePicker
            // 
            this.stdAdmission_dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdAdmission_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stdAdmission_dateTimePicker.Location = new System.Drawing.Point(518, 171);
            this.stdAdmission_dateTimePicker.Name = "stdAdmission_dateTimePicker";
            this.stdAdmission_dateTimePicker.Size = new System.Drawing.Size(185, 27);
            this.stdAdmission_dateTimePicker.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label6.Location = new System.Drawing.Point(68, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "DOB:";
            // 
            // stdDob_dateTimePicker
            // 
            this.stdDob_dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdDob_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stdDob_dateTimePicker.Location = new System.Drawing.Point(143, 237);
            this.stdDob_dateTimePicker.Name = "stdDob_dateTimePicker";
            this.stdDob_dateTimePicker.Size = new System.Drawing.Size(185, 27);
            this.stdDob_dateTimePicker.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Class Name-ID:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(369, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Father Name-ID:*";
            // 
            // stdClassEdit_comboBox
            // 
            this.stdClassEdit_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdClassEdit_comboBox.FormattingEnabled = true;
            this.stdClassEdit_comboBox.Location = new System.Drawing.Point(143, 167);
            this.stdClassEdit_comboBox.Name = "stdClassEdit_comboBox";
            this.stdClassEdit_comboBox.Size = new System.Drawing.Size(185, 29);
            this.stdClassEdit_comboBox.TabIndex = 23;
            this.stdClassEdit_comboBox.SelectedIndexChanged += new System.EventHandler(this.stdClass_comboBox_SelectedIndexChanged);
            // 
            // lblstd
            // 
            this.lblstd.AutoSize = true;
            this.lblstd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.lblstd.Location = new System.Drawing.Point(367, 22);
            this.lblstd.Name = "lblstd";
            this.lblstd.Size = new System.Drawing.Size(145, 28);
            this.lblstd.TabIndex = 24;
            this.lblstd.Text = "Edit Student";
            // 
            // stdFatherEdit_comboBox
            // 
            this.stdFatherEdit_comboBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdFatherEdit_comboBox.FormattingEnabled = true;
            this.stdFatherEdit_comboBox.Location = new System.Drawing.Point(518, 92);
            this.stdFatherEdit_comboBox.Name = "stdFatherEdit_comboBox";
            this.stdFatherEdit_comboBox.Size = new System.Drawing.Size(185, 29);
            this.stdFatherEdit_comboBox.TabIndex = 22;
            // 
            // stdAddress_txtbox
            // 
            this.stdAddress_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdAddress_txtbox.Location = new System.Drawing.Point(518, 247);
            this.stdAddress_txtbox.Name = "stdAddress_txtbox";
            this.stdAddress_txtbox.Size = new System.Drawing.Size(185, 27);
            this.stdAddress_txtbox.TabIndex = 21;
            // 
            // stdStatus_textBox
            // 
            this.stdStatus_textBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdStatus_textBox.Location = new System.Drawing.Point(143, 319);
            this.stdStatus_textBox.Name = "stdStatus_textBox";
            this.stdStatus_textBox.Size = new System.Drawing.Size(185, 27);
            this.stdStatus_textBox.TabIndex = 20;
            // 
            // stdName_txtbox
            // 
            this.stdName_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdName_txtbox.Location = new System.Drawing.Point(143, 92);
            this.stdName_txtbox.Name = "stdName_txtbox";
            this.stdName_txtbox.Size = new System.Drawing.Size(185, 27);
            this.stdName_txtbox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label5.Location = new System.Drawing.Point(391, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label9.Location = new System.Drawing.Point(396, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cell No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label8.Location = new System.Drawing.Point(68, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:*";
            // 
            // studentId_txtbox
            // 
            this.studentId_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.studentId_txtbox.Location = new System.Drawing.Point(671, 22);
            this.studentId_txtbox.Name = "studentId_txtbox";
            this.studentId_txtbox.Size = new System.Drawing.Size(185, 27);
            this.studentId_txtbox.TabIndex = 40;
            this.studentId_txtbox.Visible = false;
            // 
            // studentId_lbl
            // 
            this.studentId_lbl.AutoSize = true;
            this.studentId_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentId_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.studentId_lbl.Location = new System.Drawing.Point(564, 22);
            this.studentId_lbl.Name = "studentId_lbl";
            this.studentId_lbl.Size = new System.Drawing.Size(85, 19);
            this.studentId_lbl.TabIndex = 39;
            this.studentId_lbl.Text = "Student Id";
            this.studentId_lbl.Visible = false;
            // 
            // Edit_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 488);
            this.Controls.Add(this.studentId_txtbox);
            this.Controls.Add(this.studentId_lbl);
            this.Controls.Add(this.stdAdmissionError_lbl);
            this.Controls.Add(this.stdClassError_lbl);
            this.Controls.Add(this.stdFatherError_lbl);
            this.Controls.Add(this.stdNameError_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stdPhone_maskedTextBox);
            this.Controls.Add(this.stdEdit_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stdAdmission_dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stdDob_dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stdClassEdit_comboBox);
            this.Controls.Add(this.lblstd);
            this.Controls.Add(this.stdFatherEdit_comboBox);
            this.Controls.Add(this.stdAddress_txtbox);
            this.Controls.Add(this.stdStatus_textBox);
            this.Controls.Add(this.stdName_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Student";
            this.Text = "Edit_Student";
            this.Load += new System.EventHandler(this.Edit_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stdAdmissionError_lbl;
        private System.Windows.Forms.Label stdClassError_lbl;
        private System.Windows.Forms.Label stdFatherError_lbl;
        private System.Windows.Forms.Label stdNameError_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox stdPhone_maskedTextBox;
        private System.Windows.Forms.Button stdEdit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker stdAdmission_dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker stdDob_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stdClassEdit_comboBox;
        private System.Windows.Forms.Label lblstd;
        private System.Windows.Forms.ComboBox stdFatherEdit_comboBox;
        private System.Windows.Forms.TextBox stdAddress_txtbox;
        private System.Windows.Forms.TextBox stdStatus_textBox;
        private System.Windows.Forms.TextBox stdName_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentId_txtbox;
        private System.Windows.Forms.Label studentId_lbl;
    }
}