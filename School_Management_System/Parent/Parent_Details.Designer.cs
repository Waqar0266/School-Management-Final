namespace School_Management_System.Parent
{
    partial class Parent_Details
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
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementSystemDataSet = new School_Management_System.SchoolManagementSystemDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchClass_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchParent_txtbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.parentTableAdapter = new School_Management_System.SchoolManagementSystemDataSetTableAdapters.parentTableAdapter();
            this.schoolManagementSystemDataSet3 = new School_Management_System.SchoolManagementSystemDataSet3();
            this.parentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parentTableAdapter1 = new School_Management_System.SchoolManagementSystemDataSet3TableAdapters.parentTableAdapter();
            this.Parent_dataGridView = new System.Windows.Forms.DataGridView();
            this.parentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editParent_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteParent_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parent_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parentBindingSource
            // 
            this.parentBindingSource.DataMember = "parent";
            this.parentBindingSource.DataSource = this.schoolManagementSystemDataSet;
            // 
            // schoolManagementSystemDataSet
            // 
            this.schoolManagementSystemDataSet.DataSetName = "SchoolManagementSystemDataSet";
            this.schoolManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchClass_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchParent_txtbox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 72);
            this.panel1.TabIndex = 1;
            // 
            // searchClass_Btn
            // 
            this.searchClass_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchClass_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchClass_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClass_Btn.ForeColor = System.Drawing.Color.White;
            this.searchClass_Btn.Location = new System.Drawing.Point(957, 17);
            this.searchClass_Btn.Name = "searchClass_Btn";
            this.searchClass_Btn.Size = new System.Drawing.Size(137, 38);
            this.searchClass_Btn.TabIndex = 9;
            this.searchClass_Btn.Text = "Search";
            this.searchClass_Btn.UseVisualStyleBackColor = false;
            this.searchClass_Btn.Click += new System.EventHandler(this.searchClass_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By Name:";
            // 
            // searchParent_txtbox
            // 
            this.searchParent_txtbox.Location = new System.Drawing.Point(793, 24);
            this.searchParent_txtbox.Name = "searchParent_txtbox";
            this.searchParent_txtbox.Size = new System.Drawing.Size(158, 27);
            this.searchParent_txtbox.TabIndex = 7;
            this.searchParent_txtbox.TextChanged += new System.EventHandler(this.searchParent_txtbox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(419, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(213, 10);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(200, 52);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update Parent";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(7, 10);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(200, 52);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add Parent";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // parentTableAdapter
            // 
            this.parentTableAdapter.ClearBeforeFill = true;
            // 
            // schoolManagementSystemDataSet3
            // 
            this.schoolManagementSystemDataSet3.DataSetName = "SchoolManagementSystemDataSet3";
            this.schoolManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parentBindingSource1
            // 
            this.parentBindingSource1.DataMember = "parent";
            this.parentBindingSource1.DataSource = this.schoolManagementSystemDataSet3;
            // 
            // parentTableAdapter1
            // 
            this.parentTableAdapter1.ClearBeforeFill = true;
            // 
            // Parent_dataGridView
            // 
            this.Parent_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parent_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parentId,
            this.className,
            this.email,
            this.cellno,
            this.CNIC,
            this.officeNum,
            this.status,
            this.MonthlyIncome,
            this.editParent_btn,
            this.deleteParent_btn});
            this.Parent_dataGridView.Location = new System.Drawing.Point(-1, 64);
            this.Parent_dataGridView.Name = "Parent_dataGridView";
            this.Parent_dataGridView.Size = new System.Drawing.Size(1102, 502);
            this.Parent_dataGridView.TabIndex = 3;
            this.Parent_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Parent_dataGridView_CellClick);
            // 
            // parentId
            // 
            this.parentId.DataPropertyName = "pr_id";
            this.parentId.HeaderText = "Parent ID";
            this.parentId.Name = "parentId";
            this.parentId.ReadOnly = true;
            // 
            // className
            // 
            this.className.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.className.DataPropertyName = "name_";
            this.className.HeaderText = "Name";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // cellno
            // 
            this.cellno.DataPropertyName = "cell_no";
            this.cellno.HeaderText = "Cell Number";
            this.cellno.Name = "cellno";
            this.cellno.ReadOnly = true;
            // 
            // CNIC
            // 
            this.CNIC.DataPropertyName = "cnic";
            this.CNIC.HeaderText = "CNIC";
            this.CNIC.Name = "CNIC";
            // 
            // officeNum
            // 
            this.officeNum.DataPropertyName = "office_no ";
            this.officeNum.HeaderText = "Office Number";
            this.officeNum.Name = "officeNum";
            this.officeNum.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // MonthlyIncome
            // 
            this.MonthlyIncome.DataPropertyName = "monthly_income";
            this.MonthlyIncome.HeaderText = "Monthly Income";
            this.MonthlyIncome.Name = "MonthlyIncome";
            // 
            // editParent_btn
            // 
            this.editParent_btn.HeaderText = "Edit";
            this.editParent_btn.Name = "editParent_btn";
            this.editParent_btn.ReadOnly = true;
            this.editParent_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editParent_btn.Text = "Edit";
            this.editParent_btn.UseColumnTextForButtonValue = true;
            // 
            // deleteParent_btn
            // 
            this.deleteParent_btn.HeaderText = "Delete";
            this.deleteParent_btn.Name = "deleteParent_btn";
            this.deleteParent_btn.ReadOnly = true;
            this.deleteParent_btn.Text = "Delete";
            this.deleteParent_btn.UseColumnTextForButtonValue = true;
            // 
            // Parent_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.Parent_dataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Parent_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent_Details";
            this.Load += new System.EventHandler(this.Parent_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parent_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchClass_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchParent_txtbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private SchoolManagementSystemDataSet schoolManagementSystemDataSet;
        private System.Windows.Forms.BindingSource parentBindingSource;
        private SchoolManagementSystemDataSetTableAdapters.parentTableAdapter parentTableAdapter;
        private SchoolManagementSystemDataSet3 schoolManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource parentBindingSource1;
        private SchoolManagementSystemDataSet3TableAdapters.parentTableAdapter parentTableAdapter1;
        private System.Windows.Forms.DataGridView Parent_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyIncome;
        private System.Windows.Forms.DataGridViewButtonColumn editParent_btn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteParent_btn;
    }
}