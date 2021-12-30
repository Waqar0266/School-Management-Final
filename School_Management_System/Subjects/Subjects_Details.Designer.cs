namespace School_Management_System.Subjects
{
    partial class Subjects_Details
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
            this.searchSubject_Combo = new System.Windows.Forms.ComboBox();
            this.searchSubject_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchSubject_txtbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.Subject_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subject_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchSubject_Combo
            // 
            this.searchSubject_Combo.FormattingEnabled = true;
            this.searchSubject_Combo.Items.AddRange(new object[] {
            "Class",
            "Author"});
            this.searchSubject_Combo.Location = new System.Drawing.Point(760, 23);
            this.searchSubject_Combo.Name = "searchSubject_Combo";
            this.searchSubject_Combo.Size = new System.Drawing.Size(133, 29);
            this.searchSubject_Combo.TabIndex = 10;
            // 
            // searchSubject_btn
            // 
            this.searchSubject_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchSubject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchSubject_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSubject_btn.ForeColor = System.Drawing.Color.White;
            this.searchSubject_btn.Location = new System.Drawing.Point(1063, 17);
            this.searchSubject_btn.Name = "searchSubject_btn";
            this.searchSubject_btn.Size = new System.Drawing.Size(137, 38);
            this.searchSubject_btn.TabIndex = 9;
            this.searchSubject_btn.Text = "Search";
            this.searchSubject_btn.UseVisualStyleBackColor = false;
            this.searchSubject_btn.Click += new System.EventHandler(this.searchSubject_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By Name:";
            // 
            // searchSubject_txtbox
            // 
            this.searchSubject_txtbox.Location = new System.Drawing.Point(899, 23);
            this.searchSubject_txtbox.Name = "searchSubject_txtbox";
            this.searchSubject_txtbox.Size = new System.Drawing.Size(158, 27);
            this.searchSubject_txtbox.TabIndex = 7;
            this.searchSubject_txtbox.TextChanged += new System.EventHandler(this.searchSubject_txtbox_TextChanged);
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
            this.btnadd.Text = "Add Subject";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchSubject_Combo);
            this.panel1.Controls.Add(this.searchSubject_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchSubject_txtbox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 72);
            this.panel1.TabIndex = 4;
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
            this.btnupdate.Text = "Update Subject";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Subject_dataGridView
            // 
            this.Subject_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Subject_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Subject_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SubjectName,
            this.Author,
            this.Descripition,
            this.Edit,
            this.Delete});
            this.Subject_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Subject_dataGridView.Location = new System.Drawing.Point(0, 68);
            this.Subject_dataGridView.Name = "Subject_dataGridView";
            this.Subject_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Subject_dataGridView.Size = new System.Drawing.Size(1209, 538);
            this.Subject_dataGridView.TabIndex = 3;
            this.Subject_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Subject_dataGridView_CellClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 59.08629F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "name_";
            this.SubjectName.FillWeight = 59.08629F;
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "author";
            this.Author.FillWeight = 59.08629F;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Descripition
            // 
            this.Descripition.DataPropertyName = "descripition";
            this.Descripition.FillWeight = 59.08629F;
            this.Descripition.HeaderText = "Descripition";
            this.Descripition.Name = "Descripition";
            this.Descripition.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // Subjects_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Subject_dataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Subjects_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects_Details";
            this.Load += new System.EventHandler(this.Subject_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subject_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchSubject_Combo;
        private System.Windows.Forms.Button searchSubject_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchSubject_txtbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView Subject_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripition;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}