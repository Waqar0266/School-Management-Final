namespace School_Management_System.Class
{
    partial class Add_Class
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
            this.Name_lbl = new System.Windows.Forms.Label();
            this.className_Txtbox = new System.Windows.Forms.TextBox();
            this.No_of_std_lbl = new System.Windows.Forms.Label();
            this.noStd_Txtbox = new System.Windows.Forms.TextBox();
            this.No_of_tables_lbl = new System.Windows.Forms.Label();
            this.noTable_Txtbox = new System.Windows.Forms.TextBox();
            this.No_of_chairs_lbl = new System.Windows.Forms.Label();
            this.NoChairs_Txtbox = new System.Windows.Forms.TextBox();
            this.Section_lbl = new System.Windows.Forms.Label();
            this.section_Txtbox = new System.Windows.Forms.TextBox();
            this.classAdd_Btn = new System.Windows.Forms.Button();
            this.lblclass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorClassName_lbl = new System.Windows.Forms.Label();
            this.errorSection_lbl = new System.Windows.Forms.Label();
            this.errorNoStd_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.Name_lbl.Location = new System.Drawing.Point(112, 101);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(73, 19);
            this.Name_lbl.TabIndex = 0;
            this.Name_lbl.Text = "Name: *";
            // 
            // className_Txtbox
            // 
            this.className_Txtbox.Location = new System.Drawing.Point(196, 98);
            this.className_Txtbox.Name = "className_Txtbox";
            this.className_Txtbox.Size = new System.Drawing.Size(255, 27);
            this.className_Txtbox.TabIndex = 1;
            this.className_Txtbox.TextChanged += new System.EventHandler(this.className_Txtbox_TextChanged);
            // 
            // No_of_std_lbl
            // 
            this.No_of_std_lbl.AutoSize = true;
            this.No_of_std_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.No_of_std_lbl.Location = new System.Drawing.Point(60, 203);
            this.No_of_std_lbl.Name = "No_of_std_lbl";
            this.No_of_std_lbl.Size = new System.Drawing.Size(130, 19);
            this.No_of_std_lbl.TabIndex = 0;
            this.No_of_std_lbl.Text = "No Of Students:*";
            // 
            // noStd_Txtbox
            // 
            this.noStd_Txtbox.Location = new System.Drawing.Point(196, 200);
            this.noStd_Txtbox.Name = "noStd_Txtbox";
            this.noStd_Txtbox.Size = new System.Drawing.Size(255, 27);
            this.noStd_Txtbox.TabIndex = 1;
            // 
            // No_of_tables_lbl
            // 
            this.No_of_tables_lbl.AutoSize = true;
            this.No_of_tables_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.No_of_tables_lbl.Location = new System.Drawing.Point(78, 302);
            this.No_of_tables_lbl.Name = "No_of_tables_lbl";
            this.No_of_tables_lbl.Size = new System.Drawing.Size(109, 19);
            this.No_of_tables_lbl.TabIndex = 0;
            this.No_of_tables_lbl.Text = "No Of Tables:";
            // 
            // noTable_Txtbox
            // 
            this.noTable_Txtbox.Location = new System.Drawing.Point(196, 148);
            this.noTable_Txtbox.Name = "noTable_Txtbox";
            this.noTable_Txtbox.Size = new System.Drawing.Size(255, 27);
            this.noTable_Txtbox.TabIndex = 1;
            // 
            // No_of_chairs_lbl
            // 
            this.No_of_chairs_lbl.AutoSize = true;
            this.No_of_chairs_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.No_of_chairs_lbl.Location = new System.Drawing.Point(79, 254);
            this.No_of_chairs_lbl.Name = "No_of_chairs_lbl";
            this.No_of_chairs_lbl.Size = new System.Drawing.Size(108, 19);
            this.No_of_chairs_lbl.TabIndex = 0;
            this.No_of_chairs_lbl.Text = "No Of Chairs:";
            // 
            // NoChairs_Txtbox
            // 
            this.NoChairs_Txtbox.Location = new System.Drawing.Point(196, 246);
            this.NoChairs_Txtbox.Name = "NoChairs_Txtbox";
            this.NoChairs_Txtbox.Size = new System.Drawing.Size(255, 27);
            this.NoChairs_Txtbox.TabIndex = 1;
            this.NoChairs_Txtbox.TextChanged += new System.EventHandler(this.NoChairs_Txtbox_TextChanged);
            // 
            // Section_lbl
            // 
            this.Section_lbl.AutoSize = true;
            this.Section_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.Section_lbl.Location = new System.Drawing.Point(112, 148);
            this.Section_lbl.Name = "Section_lbl";
            this.Section_lbl.Size = new System.Drawing.Size(76, 19);
            this.Section_lbl.TabIndex = 0;
            this.Section_lbl.Text = "Section:*";
            // 
            // section_Txtbox
            // 
            this.section_Txtbox.Location = new System.Drawing.Point(196, 294);
            this.section_Txtbox.Name = "section_Txtbox";
            this.section_Txtbox.Size = new System.Drawing.Size(255, 27);
            this.section_Txtbox.TabIndex = 1;
            // 
            // classAdd_Btn
            // 
            this.classAdd_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.classAdd_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classAdd_Btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classAdd_Btn.ForeColor = System.Drawing.Color.White;
            this.classAdd_Btn.Location = new System.Drawing.Point(196, 335);
            this.classAdd_Btn.Name = "classAdd_Btn";
            this.classAdd_Btn.Size = new System.Drawing.Size(200, 52);
            this.classAdd_Btn.TabIndex = 2;
            this.classAdd_Btn.Text = "Add";
            this.classAdd_Btn.UseVisualStyleBackColor = false;
            this.classAdd_Btn.Click += new System.EventHandler(this.classAdd_Btn_Click);
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.lblclass.Location = new System.Drawing.Point(225, 31);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(161, 25);
            this.lblclass.TabIndex = 3;
            this.lblclass.Text = "Add NewClass";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorClassName_lbl
            // 
            this.errorClassName_lbl.AutoSize = true;
            this.errorClassName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.errorClassName_lbl.Location = new System.Drawing.Point(457, 101);
            this.errorClassName_lbl.Name = "errorClassName_lbl";
            this.errorClassName_lbl.Size = new System.Drawing.Size(208, 19);
            this.errorClassName_lbl.TabIndex = 6;
            this.errorClassName_lbl.Text = "Class name is mandatory ";
            this.errorClassName_lbl.Visible = false;
            // 
            // errorSection_lbl
            // 
            this.errorSection_lbl.AutoSize = true;
            this.errorSection_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.errorSection_lbl.Location = new System.Drawing.Point(457, 148);
            this.errorSection_lbl.Name = "errorSection_lbl";
            this.errorSection_lbl.Size = new System.Drawing.Size(170, 19);
            this.errorSection_lbl.TabIndex = 7;
            this.errorSection_lbl.Text = "Section is mandatory";
            this.errorSection_lbl.Visible = false;
            // 
            // errorNoStd_lbl
            // 
            this.errorNoStd_lbl.AutoSize = true;
            this.errorNoStd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.errorNoStd_lbl.Location = new System.Drawing.Point(457, 203);
            this.errorNoStd_lbl.Name = "errorNoStd_lbl";
            this.errorNoStd_lbl.Size = new System.Drawing.Size(205, 19);
            this.errorNoStd_lbl.TabIndex = 8;
            this.errorNoStd_lbl.Text = "No of students mandatory";
            this.errorNoStd_lbl.Visible = false;
            // 
            // Add_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 491);
            this.Controls.Add(this.errorNoStd_lbl);
            this.Controls.Add(this.errorSection_lbl);
            this.Controls.Add(this.errorClassName_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.classAdd_Btn);
            this.Controls.Add(this.NoChairs_Txtbox);
            this.Controls.Add(this.section_Txtbox);
            this.Controls.Add(this.noTable_Txtbox);
            this.Controls.Add(this.noStd_Txtbox);
            this.Controls.Add(this.className_Txtbox);
            this.Controls.Add(this.No_of_chairs_lbl);
            this.Controls.Add(this.Section_lbl);
            this.Controls.Add(this.No_of_tables_lbl);
            this.Controls.Add(this.No_of_std_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Class";
            this.Text = "Add_Class";
            this.Load += new System.EventHandler(this.Add_Class_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox className_Txtbox;
        private System.Windows.Forms.Label No_of_std_lbl;
        private System.Windows.Forms.TextBox noStd_Txtbox;
        private System.Windows.Forms.Label No_of_tables_lbl;
        private System.Windows.Forms.TextBox noTable_Txtbox;
        private System.Windows.Forms.Label No_of_chairs_lbl;
        private System.Windows.Forms.TextBox NoChairs_Txtbox;
        private System.Windows.Forms.Label Section_lbl;
        private System.Windows.Forms.TextBox section_Txtbox;
        private System.Windows.Forms.Button classAdd_Btn;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorClassName_lbl;
        private System.Windows.Forms.Label errorSection_lbl;
        private System.Windows.Forms.Label errorNoStd_lbl;
    }
}