namespace SaleWinApp
{
    partial class FormMember
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
            lbTitle = new Label();
            lbID = new Label();
            lbEmail = new Label();
            lbCompany = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            dgvMemberList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(173, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(263, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Member Management";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(36, 54);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(36, 105);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(36, 156);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(72, 20);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Company";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(329, 54);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(329, 105);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(329, 156);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 235);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new Size(598, 227);
            dgvMemberList.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(96, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(263, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(435, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(263, 471);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(106, 51);
            txtID.Name = "txtID";
            txtID.Size = new Size(184, 27);
            txtID.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(106, 153);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(184, 27);
            txtCompany.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(398, 51);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(191, 27);
            txtCity.TabIndex = 15;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(398, 102);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(191, 27);
            txtCountry.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(398, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 27);
            txtPassword.TabIndex = 17;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 512);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvMemberList);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompany);
            Controls.Add(lbEmail);
            Controls.Add(lbID);
            Controls.Add(lbTitle);
            Name = "FormMember";
            Text = "FormMember";
            Load += FormMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbID;
        private Label lbEmail;
        private Label lbCompany;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private DataGridView dgvMemberList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
    }
}