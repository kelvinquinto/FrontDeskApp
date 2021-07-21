namespace FrontDeskApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.intCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPackage = new System.Windows.Forms.DataGridView();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSmall = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.txtSmall = new System.Windows.Forms.TextBox();
            this.txtMedium = new System.Windows.Forms.TextBox();
            this.txtLarge = new System.Windows.Forms.TextBox();
            this.intPackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPackageCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPackageCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strRetrieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCustomerId,
            this.strFirstName,
            this.strLastName,
            this.strPhoneNumber});
            this.dgvCustomer.Location = new System.Drawing.Point(300, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(488, 179);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // intCustomerId
            // 
            this.intCustomerId.DataPropertyName = "intCustomerId";
            this.intCustomerId.HeaderText = "intCustomerId";
            this.intCustomerId.Name = "intCustomerId";
            this.intCustomerId.ReadOnly = true;
            this.intCustomerId.Visible = false;
            // 
            // strFirstName
            // 
            this.strFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strFirstName.DataPropertyName = "strFirstName";
            this.strFirstName.HeaderText = "First Name";
            this.strFirstName.Name = "strFirstName";
            this.strFirstName.ReadOnly = true;
            // 
            // strLastName
            // 
            this.strLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strLastName.DataPropertyName = "strLastName";
            this.strLastName.HeaderText = "Last Name";
            this.strLastName.Name = "strLastName";
            this.strLastName.ReadOnly = true;
            // 
            // strPhoneNumber
            // 
            this.strPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strPhoneNumber.DataPropertyName = "strPhoneNumber";
            this.strPhoneNumber.HeaderText = "Phone Number";
            this.strPhoneNumber.Name = "strPhoneNumber";
            this.strPhoneNumber.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(184, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 52);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(184, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(90, 84);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(184, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(9, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Enabled = false;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(90, 299);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(184, 21);
            this.cmbCategory.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(9, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Package Size";
            // 
            // dgvPackage
            // 
            this.dgvPackage.AllowUserToDeleteRows = false;
            this.dgvPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intPackageId,
            this.intPackageCustomerId,
            this.intPackageCategoryId,
            this.strPackageName,
            this.strCategory,
            this.strRetrieved,
            this.dtmDate});
            this.dgvPackage.Location = new System.Drawing.Point(300, 197);
            this.dgvPackage.Name = "dgvPackage";
            this.dgvPackage.ReadOnly = true;
            this.dgvPackage.Size = new System.Drawing.Size(488, 185);
            this.dgvPackage.TabIndex = 12;
            this.dgvPackage.DoubleClick += new System.EventHandler(this.dgvPackage_DoubleClick);
            // 
            // btnStore
            // 
            this.btnStore.Enabled = false;
            this.btnStore.Location = new System.Drawing.Point(9, 330);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(265, 23);
            this.btnStore.TabIndex = 14;
            this.btnStore.Text = "Store Package";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Enabled = false;
            this.btnRetrieve.Location = new System.Drawing.Point(9, 359);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(265, 23);
            this.btnRetrieve.TabIndex = 15;
            this.btnRetrieve.Text = "Retrive Package";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Available slots:";
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Location = new System.Drawing.Point(14, 233);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(38, 13);
            this.lblSmall.TabIndex = 17;
            this.lblSmall.Text = "Small: ";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Location = new System.Drawing.Point(13, 258);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(47, 13);
            this.lblMedium.TabIndex = 18;
            this.lblMedium.Text = "Medium:";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Location = new System.Drawing.Point(14, 280);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(37, 13);
            this.lblLarge.TabIndex = 19;
            this.lblLarge.Text = "Large:";
            // 
            // txtSmall
            // 
            this.txtSmall.Location = new System.Drawing.Point(90, 226);
            this.txtSmall.Name = "txtSmall";
            this.txtSmall.ReadOnly = true;
            this.txtSmall.Size = new System.Drawing.Size(47, 20);
            this.txtSmall.TabIndex = 20;
            // 
            // txtMedium
            // 
            this.txtMedium.Location = new System.Drawing.Point(90, 251);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.ReadOnly = true;
            this.txtMedium.Size = new System.Drawing.Size(47, 20);
            this.txtMedium.TabIndex = 21;
            // 
            // txtLarge
            // 
            this.txtLarge.Location = new System.Drawing.Point(90, 273);
            this.txtLarge.Name = "txtLarge";
            this.txtLarge.ReadOnly = true;
            this.txtLarge.Size = new System.Drawing.Size(47, 20);
            this.txtLarge.TabIndex = 22;
            // 
            // intPackageId
            // 
            this.intPackageId.DataPropertyName = "intPackageId";
            this.intPackageId.HeaderText = "Package Id";
            this.intPackageId.Name = "intPackageId";
            this.intPackageId.ReadOnly = true;
            this.intPackageId.Visible = false;
            // 
            // intPackageCustomerId
            // 
            this.intPackageCustomerId.DataPropertyName = "intPackageCustomerId";
            this.intPackageCustomerId.HeaderText = "PackageCustomerId";
            this.intPackageCustomerId.Name = "intPackageCustomerId";
            this.intPackageCustomerId.ReadOnly = true;
            this.intPackageCustomerId.Visible = false;
            // 
            // intPackageCategoryId
            // 
            this.intPackageCategoryId.DataPropertyName = "intPackageCategoryId";
            this.intPackageCategoryId.HeaderText = "CategoryId";
            this.intPackageCategoryId.Name = "intPackageCategoryId";
            this.intPackageCategoryId.ReadOnly = true;
            this.intPackageCategoryId.Visible = false;
            // 
            // strPackageName
            // 
            this.strPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strPackageName.DataPropertyName = "strPackageName";
            this.strPackageName.HeaderText = "Package Name";
            this.strPackageName.Name = "strPackageName";
            this.strPackageName.ReadOnly = true;
            // 
            // strCategory
            // 
            this.strCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strCategory.DataPropertyName = "strCategory";
            this.strCategory.HeaderText = "Size";
            this.strCategory.Name = "strCategory";
            this.strCategory.ReadOnly = true;
            // 
            // strRetrieved
            // 
            this.strRetrieved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strRetrieved.DataPropertyName = "strRetrieved";
            this.strRetrieved.HeaderText = "Status";
            this.strRetrieved.Name = "strRetrieved";
            this.strRetrieved.ReadOnly = true;
            // 
            // dtmDate
            // 
            this.dtmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtmDate.DataPropertyName = "dtmDate";
            this.dtmDate.HeaderText = "Date";
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.txtLarge);
            this.Controls.Add(this.txtMedium);
            this.Controls.Add(this.txtSmall);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblSmall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.dgvPackage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Front Desk App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strPhoneNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPackage;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.TextBox txtSmall;
        private System.Windows.Forms.TextBox txtMedium;
        private System.Windows.Forms.TextBox txtLarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPackageCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPackageCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn strPackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn strRetrieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtmDate;
    }
}

