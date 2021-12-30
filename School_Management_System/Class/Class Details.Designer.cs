namespace School_Management_System.Class
{
    partial class Class_Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchClass_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchClass_txtbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.class_dataGridView = new System.Windows.Forms.DataGridView();
            this.classId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfChairs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfTables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editClass_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteClass_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.classVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.classVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.searchClass_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchClass_txtbox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 73);
            this.panel1.TabIndex = 1;
            // 
            // searchClass_btn
            // 
            this.searchClass_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchClass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchClass_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClass_btn.ForeColor = System.Drawing.Color.White;
            this.searchClass_btn.Location = new System.Drawing.Point(961, 18);
            this.searchClass_btn.Name = "searchClass_btn";
            this.searchClass_btn.Size = new System.Drawing.Size(137, 38);
            this.searchClass_btn.TabIndex = 3;
            this.searchClass_btn.Text = "Search";
            this.searchClass_btn.UseVisualStyleBackColor = false;
            this.searchClass_btn.Click += new System.EventHandler(this.searchClass_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // searchClass_txtbox
            // 
            this.searchClass_txtbox.Location = new System.Drawing.Point(797, 25);
            this.searchClass_txtbox.Name = "searchClass_txtbox";
            this.searchClass_txtbox.Size = new System.Drawing.Size(158, 27);
            this.searchClass_txtbox.TabIndex = 1;
            this.searchClass_txtbox.TextChanged += new System.EventHandler(this.searchClass_txtbox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(423, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 52);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(217, 11);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(200, 52);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Update Class";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(11, 11);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(200, 52);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add Class";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // class_dataGridView
            // 
            this.class_dataGridView.AllowUserToOrderColumns = true;
            this.class_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.class_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classId,
            this.className,
            this.section,
            this.noOfStd,
            this.noOfChairs,
            this.noOfTables,
            this.editClass_btn,
            this.deleteClass_btn});
            this.class_dataGridView.Location = new System.Drawing.Point(0, 94);
            this.class_dataGridView.Name = "class_dataGridView";
            this.class_dataGridView.Size = new System.Drawing.Size(1102, 502);
            this.class_dataGridView.TabIndex = 2;
            this.class_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.class_dataGridView_CellClick);
            this.class_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.class_dataGridView_CellContentClick_1);
            // 
            // classId
            // 
            this.classId.DataPropertyName = "class_id";
            this.classId.HeaderText = "ClassId";
            this.classId.Name = "classId";
            this.classId.ReadOnly = true;
            // 
            // className
            // 
            this.className.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.className.DataPropertyName = "name";
            this.className.HeaderText = "Class Name";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // section
            // 
            this.section.DataPropertyName = "section_";
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // noOfStd
            // 
            this.noOfStd.DataPropertyName = "no_of_std";
            this.noOfStd.HeaderText = "No Of Students";
            this.noOfStd.Name = "noOfStd";
            this.noOfStd.ReadOnly = true;
            // 
            // noOfChairs
            // 
            this.noOfChairs.DataPropertyName = "no_of_chairs";
            this.noOfChairs.HeaderText = "No Of Chairs";
            this.noOfChairs.Name = "noOfChairs";
            this.noOfChairs.ReadOnly = true;
            // 
            // noOfTables
            // 
            this.noOfTables.DataPropertyName = "no_of_tables";
            this.noOfTables.HeaderText = "No Of Tables";
            this.noOfTables.Name = "noOfTables";
            this.noOfTables.ReadOnly = true;
            // 
            // editClass_btn
            // 
            this.editClass_btn.HeaderText = "Edit";
            this.editClass_btn.Name = "editClass_btn";
            this.editClass_btn.ReadOnly = true;
            this.editClass_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editClass_btn.Text = "Edit";
            this.editClass_btn.UseColumnTextForButtonValue = true;
            // 
            // deleteClass_btn
            // 
            this.deleteClass_btn.HeaderText = "Delete";
            this.deleteClass_btn.Name = "deleteClass_btn";
            this.deleteClass_btn.ReadOnly = true;
            this.deleteClass_btn.Text = "Delete";
            this.deleteClass_btn.UseColumnTextForButtonValue = true;
            // 
            // classVMBindingSource3
            // 
            this.classVMBindingSource3.DataSource = typeof(School_Management_System.ViewModel.ClassVM);
            // 
            // classVMBindingSource2
            // 
            this.classVMBindingSource2.DataSource = typeof(School_Management_System.ViewModel.ClassVM);
            // 
            // classVMBindingSource1
            // 
            this.classVMBindingSource1.DataSource = typeof(School_Management_System.ViewModel.ClassVM);
            // 
            // classVMBindingSource
            // 
            this.classVMBindingSource.DataSource = typeof(School_Management_System.ViewModel.ClassVM);
            // 
            // Class_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 598);
            this.Controls.Add(this.class_dataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Class_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Details";
            this.Load += new System.EventHandler(this.Class_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchClass_txtbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button searchClass_btn;
        private System.Windows.Forms.BindingSource classVMBindingSource;
        private System.Windows.Forms.BindingSource classVMBindingSource1;
        private System.Windows.Forms.BindingSource classVMBindingSource2;
        private System.Windows.Forms.BindingSource classVMBindingSource3;
        private System.Windows.Forms.DataGridView class_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn classId;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfChairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfTables;
        private System.Windows.Forms.DataGridViewButtonColumn editClass_btn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteClass_btn;
    }
}