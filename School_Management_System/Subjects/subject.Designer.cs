namespace School_Management_System.Subjects
{
    partial class subject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectName = new System.Windows.Forms.TextBox();
            this.subjectClassID = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementSystemDataSet1 = new School_Management_System.SchoolManagementSystemDataSet1();
            this.lblsub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectAuth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectDesc = new System.Windows.Forms.RichTextBox();
            this.subjectAdd = new System.Windows.Forms.Button();
            this.classTableAdapter = new School_Management_System.SchoolManagementSystemDataSet1TableAdapters.classTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(136, 69);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(164, 27);
            this.subjectName.TabIndex = 1;
            // 
            // subjectClassID
            // 
            this.subjectClassID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classBindingSource, "class_id", true));
            this.subjectClassID.FormattingEnabled = true;
            this.subjectClassID.Location = new System.Drawing.Point(445, 69);
            this.subjectClassID.Name = "subjectClassID";
            this.subjectClassID.Size = new System.Drawing.Size(174, 29);
            this.subjectClassID.TabIndex = 2;
            this.subjectClassID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.schoolManagementSystemDataSet1;
            // 
            // schoolManagementSystemDataSet1
            // 
            this.schoolManagementSystemDataSet1.DataSetName = "SchoolManagementSystemDataSet1";
            this.schoolManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(162)))));
            this.lblsub.Location = new System.Drawing.Point(236, 22);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(189, 25);
            this.lblsub.TabIndex = 3;
            this.lblsub.Text = "Add New Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(162)))));
            this.label2.Location = new System.Drawing.Point(316, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class Name-ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(162)))));
            this.label3.Location = new System.Drawing.Point(66, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author:";
            // 
            // subjectAuth
            // 
            this.subjectAuth.Location = new System.Drawing.Point(136, 114);
            this.subjectAuth.Name = "subjectAuth";
            this.subjectAuth.Size = new System.Drawing.Size(164, 27);
            this.subjectAuth.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(162)))));
            this.label4.Location = new System.Drawing.Point(337, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripition:";
            // 
            // subjectDesc
            // 
            this.subjectDesc.Location = new System.Drawing.Point(445, 118);
            this.subjectDesc.Name = "subjectDesc";
            this.subjectDesc.Size = new System.Drawing.Size(174, 96);
            this.subjectDesc.TabIndex = 6;
            this.subjectDesc.Text = "";
            // 
            // subjectAdd
            // 
            this.subjectAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.subjectAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectAdd.ForeColor = System.Drawing.Color.White;
            this.subjectAdd.Location = new System.Drawing.Point(175, 180);
            this.subjectAdd.Name = "subjectAdd";
            this.subjectAdd.Size = new System.Drawing.Size(200, 52);
            this.subjectAdd.TabIndex = 7;
            this.subjectAdd.Text = "Add Subject";
            this.subjectAdd.UseVisualStyleBackColor = false;
            this.subjectAdd.Click += new System.EventHandler(this.subjectAdd_Click);
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(this.subjectAdd);
            this.Controls.Add(this.subjectDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.subjectClassID);
            this.Controls.Add(this.subjectAuth);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "subject";
            this.Load += new System.EventHandler(this.subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.ComboBox subjectClassID;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox subjectDesc;
        private System.Windows.Forms.Button subjectAdd;
        private SchoolManagementSystemDataSet1 schoolManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private SchoolManagementSystemDataSet1TableAdapters.classTableAdapter classTableAdapter;
    }
}