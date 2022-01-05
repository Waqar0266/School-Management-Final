namespace School_Management_System.Noticses
{
    partial class Notice_Edit
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
            this.lblexam = new System.Windows.Forms.Label();
            this.EditNotices = new System.Windows.Forms.Button();
            this.EditNoticesDescription = new System.Windows.Forms.RichTextBox();
            this.EditNoticesDate = new System.Windows.Forms.DateTimePicker();
            this.EditNoticesName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblexam
            // 
            this.lblexam.AutoSize = true;
            this.lblexam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.lblexam.Location = new System.Drawing.Point(119, 19);
            this.lblexam.Name = "lblexam";
            this.lblexam.Size = new System.Drawing.Size(189, 25);
            this.lblexam.TabIndex = 31;
            this.lblexam.Text = "Add New Notices";
            // 
            // EditNotices
            // 
            this.EditNotices.BackColor = System.Drawing.Color.SteelBlue;
            this.EditNotices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditNotices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditNotices.ForeColor = System.Drawing.Color.White;
            this.EditNotices.Location = new System.Drawing.Point(117, 335);
            this.EditNotices.Name = "EditNotices";
            this.EditNotices.Size = new System.Drawing.Size(200, 52);
            this.EditNotices.TabIndex = 30;
            this.EditNotices.Text = "Save Notices";
            this.EditNotices.UseVisualStyleBackColor = false;
            this.EditNotices.Click += new System.EventHandler(this.EditNotices_Click);
            // 
            // EditNoticesDescription
            // 
            this.EditNoticesDescription.Location = new System.Drawing.Point(117, 173);
            this.EditNoticesDescription.Name = "EditNoticesDescription";
            this.EditNoticesDescription.Size = new System.Drawing.Size(264, 119);
            this.EditNoticesDescription.TabIndex = 29;
            this.EditNoticesDescription.Text = "";
            // 
            // EditNoticesDate
            // 
            this.EditNoticesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditNoticesDate.Location = new System.Drawing.Point(124, 132);
            this.EditNoticesDate.Name = "EditNoticesDate";
            this.EditNoticesDate.Size = new System.Drawing.Size(183, 20);
            this.EditNoticesDate.TabIndex = 28;
            // 
            // EditNoticesName
            // 
            this.EditNoticesName.Location = new System.Drawing.Point(124, 87);
            this.EditNoticesName.Name = "EditNoticesName";
            this.EditNoticesName.Size = new System.Drawing.Size(183, 20);
            this.EditNoticesName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(9, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(65, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(65, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date:";
            // 
            // Notice_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.lblexam);
            this.Controls.Add(this.EditNotices);
            this.Controls.Add(this.EditNoticesDescription);
            this.Controls.Add(this.EditNoticesDate);
            this.Controls.Add(this.EditNoticesName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Notice_Edit";
            this.Text = "Notice_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblexam;
        private System.Windows.Forms.Button EditNotices;
        private System.Windows.Forms.RichTextBox EditNoticesDescription;
        private System.Windows.Forms.DateTimePicker EditNoticesDate;
        private System.Windows.Forms.TextBox EditNoticesName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}