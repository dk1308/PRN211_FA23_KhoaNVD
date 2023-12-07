namespace SaleWinApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            lbAskAdmin = new Label();
            lbAskMember = new Label();
            btnAdminPage = new Button();
            btnMemberPage = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(141, 41);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(224, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Welcome to FStore";
            // 
            // lbAskAdmin
            // 
            lbAskAdmin.AutoSize = true;
            lbAskAdmin.Location = new Point(161, 125);
            lbAskAdmin.Name = "lbAskAdmin";
            lbAskAdmin.Size = new Size(111, 20);
            lbAskAdmin.TabIndex = 1;
            lbAskAdmin.Text = "You are admin?";
            // 
            // lbAskMember
            // 
            lbAskMember.AutoSize = true;
            lbAskMember.Location = new Point(161, 219);
            lbAskMember.Name = "lbAskMember";
            lbAskMember.Size = new Size(125, 20);
            lbAskMember.TabIndex = 2;
            lbAskMember.Text = "You are member?";
            // 
            // btnAdminPage
            // 
            btnAdminPage.Location = new Point(161, 148);
            btnAdminPage.Name = "btnAdminPage";
            btnAdminPage.Size = new Size(204, 30);
            btnAdminPage.TabIndex = 3;
            btnAdminPage.Text = "Go to Admin page";
            btnAdminPage.UseVisualStyleBackColor = true;
            btnAdminPage.Click += btnAdminPage_Click;
            // 
            // btnMemberPage
            // 
            btnMemberPage.Location = new Point(161, 242);
            btnMemberPage.Name = "btnMemberPage";
            btnMemberPage.Size = new Size(204, 29);
            btnMemberPage.TabIndex = 4;
            btnMemberPage.TabStop = false;
            btnMemberPage.Text = "Go to Member page";
            btnMemberPage.UseVisualStyleBackColor = false;
            btnMemberPage.Click += btnMemberPage_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(388, 327);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 365);
            Controls.Add(btnClose);
            Controls.Add(btnMemberPage);
            Controls.Add(btnAdminPage);
            Controls.Add(lbAskMember);
            Controls.Add(lbAskAdmin);
            Controls.Add(lbTitle);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbAskAdmin;
        private Label lbAskMember;
        private Button btnAdminPage;
        private Button btnMemberPage;
        private Button btnClose;
    }
}