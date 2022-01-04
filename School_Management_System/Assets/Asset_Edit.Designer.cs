namespace School_Management_System.Assets
{
    partial class Asset_Edit
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
            this.EditAssetsBtn = new System.Windows.Forms.Button();
            this.lblast = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditAssetDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditAssetDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditAssetAmount = new System.Windows.Forms.TextBox();
            this.EditAssetType = new System.Windows.Forms.ComboBox();
            this.EditAssetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditAssetsBtn
            // 
            this.EditAssetsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.EditAssetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditAssetsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAssetsBtn.ForeColor = System.Drawing.Color.White;
            this.EditAssetsBtn.Location = new System.Drawing.Point(223, 254);
            this.EditAssetsBtn.Name = "EditAssetsBtn";
            this.EditAssetsBtn.Size = new System.Drawing.Size(200, 52);
            this.EditAssetsBtn.TabIndex = 33;
            this.EditAssetsBtn.Text = "Save";
            this.EditAssetsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditAssetsBtn.UseVisualStyleBackColor = false;
            this.EditAssetsBtn.Click += new System.EventHandler(this.EditAssetsBtn_Click);
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.lblast.Location = new System.Drawing.Point(224, 9);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(116, 25);
            this.lblast.TabIndex = 32;
            this.lblast.Text = "Edit Assets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label5.Location = new System.Drawing.Point(36, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Descripition:";
            // 
            // EditAssetDescription
            // 
            this.EditAssetDescription.Location = new System.Drawing.Point(144, 138);
            this.EditAssetDescription.Name = "EditAssetDescription";
            this.EditAssetDescription.Size = new System.Drawing.Size(446, 96);
            this.EditAssetDescription.TabIndex = 30;
            this.EditAssetDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(89, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date:";
            // 
            // EditAssetDate
            // 
            this.EditAssetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditAssetDate.Location = new System.Drawing.Point(144, 99);
            this.EditAssetDate.Name = "EditAssetDate";
            this.EditAssetDate.Size = new System.Drawing.Size(177, 20);
            this.EditAssetDate.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(332, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(345, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name:";
            // 
            // EditAssetAmount
            // 
            this.EditAssetAmount.Location = new System.Drawing.Point(413, 98);
            this.EditAssetAmount.Name = "EditAssetAmount";
            this.EditAssetAmount.Size = new System.Drawing.Size(177, 20);
            this.EditAssetAmount.TabIndex = 23;
            // 
            // EditAssetType
            // 
            this.EditAssetType.FormattingEnabled = true;
            this.EditAssetType.Items.AddRange(new object[] {
            "New",
            "Used",
            "Other"});
            this.EditAssetType.Location = new System.Drawing.Point(144, 58);
            this.EditAssetType.Name = "EditAssetType";
            this.EditAssetType.Size = new System.Drawing.Size(177, 21);
            this.EditAssetType.TabIndex = 25;
            // 
            // EditAssetName
            // 
            this.EditAssetName.Location = new System.Drawing.Point(413, 58);
            this.EditAssetName.Name = "EditAssetName";
            this.EditAssetName.Size = new System.Drawing.Size(177, 20);
            this.EditAssetName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Assets Type:";
            // 
            // Asset_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 324);
            this.Controls.Add(this.EditAssetsBtn);
            this.Controls.Add(this.lblast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditAssetDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditAssetDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditAssetAmount);
            this.Controls.Add(this.EditAssetType);
            this.Controls.Add(this.EditAssetName);
            this.Controls.Add(this.label1);
            this.Name = "Asset_Edit";
            this.Text = "Asset_Edit";
            this.Load += new System.EventHandler(this.Asset_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditAssetsBtn;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox EditAssetDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EditAssetDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditAssetAmount;
        private System.Windows.Forms.ComboBox EditAssetType;
        private System.Windows.Forms.TextBox EditAssetName;
        private System.Windows.Forms.Label label1;
    }
}