namespace SaleWinApp
{
    partial class FormMemberProfile
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
            btnViewOrders = new Button();
            btnSave = new Button();
            lbEmail = new Label();
            lbCompanyName = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            btnCancel = new Button();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // btnViewOrders
            // 
            btnViewOrders.Location = new Point(137, 348);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(336, 38);
            btnViewOrders.TabIndex = 0;
            btnViewOrders.Text = "View your orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(210, 295);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbEmail
            // 
            lbEmail.AccessibleRole = AccessibleRole.MenuBar;
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(92, 60);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(92, 109);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(112, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "CompanyName";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(92, 158);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(92, 204);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(92, 251);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(379, 295);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(210, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(210, 106);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(263, 27);
            txtCompanyName.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(210, 155);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(263, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(210, 201);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(263, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(210, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 12;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(195, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(187, 35);
            lbTitle.TabIndex = 13;
            lbTitle.Text = "Member Profile";
            // 
            // FormMemberProfile
            // 
            AcceptButton = btnCancel;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 398);
            Controls.Add(lbTitle);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbEmail);
            Controls.Add(btnSave);
            Controls.Add(btnViewOrders);
            Name = "FormMemberProfile";
            Text = "FormMemberProfile";
            Load += FormMemberProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewOrders;
        private Button btnSave;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private Button btnCancel;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Label lbTitle;
        public Label lbEmail;
    }
}