namespace School_Management_System.Student
{
    partial class Student_Details
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
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stdSearch_txtbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.stdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFatherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdAdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdId,
            this.stdName,
            this.stdFatherId,
            this.stdClassName,
            this.stdDob,
            this.stdAdmissionDate,
            this.stdStatus,
            this.Address,
            this.Edit,
            this.Delete});
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentDataGridView.Location = new System.Drawing.Point(0, 68);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(1212, 558);
            this.studentDataGridView.TabIndex = 0;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stdSearch_txtbox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 72);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // stdSearch_txtbox
            // 
            this.stdSearch_txtbox.Location = new System.Drawing.Point(1001, 25);
            this.stdSearch_txtbox.Name = "stdSearch_txtbox";
            this.stdSearch_txtbox.Size = new System.Drawing.Size(184, 27);
            this.stdSearch_txtbox.TabIndex = 7;
            this.stdSearch_txtbox.TextChanged += new System.EventHandler(this.stdSearch_txtbox_TextChanged_1);
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
            this.btnupdate.Text = "Update Student";
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
            this.btnadd.Text = "Add Student";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // stdId
            // 
            this.stdId.DataPropertyName = "std_id";
            this.stdId.HeaderText = "ID";
            this.stdId.Name = "stdId";
            this.stdId.ReadOnly = true;
            // 
            // stdName
            // 
            this.stdName.DataPropertyName = "name_";
            this.stdName.HeaderText = "Name";
            this.stdName.Name = "stdName";
            this.stdName.ReadOnly = true;
            // 
            // stdFatherId
            // 
            this.stdFatherId.DataPropertyName = "f_id";
            this.stdFatherId.HeaderText = "Father Name-ID";
            this.stdFatherId.Name = "stdFatherId";
            this.stdFatherId.ReadOnly = true;
            // 
            // stdClassName
            // 
            this.stdClassName.DataPropertyName = "class_id";
            this.stdClassName.HeaderText = "CLass Name-ID";
            this.stdClassName.Name = "stdClassName";
            this.stdClassName.ReadOnly = true;
            // 
            // stdDob
            // 
            this.stdDob.DataPropertyName = "dob";
            this.stdDob.HeaderText = "DOB";
            this.stdDob.Name = "stdDob";
            this.stdDob.ReadOnly = true;
            // 
            // stdAdmissionDate
            // 
            this.stdAdmissionDate.DataPropertyName = "admission_date";
            this.stdAdmissionDate.HeaderText = "Admission Date";
            this.stdAdmissionDate.Name = "stdAdmissionDate";
            this.stdAdmissionDate.ReadOnly = true;
            // 
            // stdStatus
            // 
            this.stdStatus.DataPropertyName = "status";
            this.stdStatus.HeaderText = "Status";
            this.stdStatus.Name = "stdStatus";
            this.stdStatus.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Details";
            this.Load += new System.EventHandler(this.Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdSearch_txtbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFatherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdAdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}