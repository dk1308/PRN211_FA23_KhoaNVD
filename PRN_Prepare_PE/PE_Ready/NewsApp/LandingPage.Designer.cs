namespace NewsApp
{
    partial class LandingPage
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
            label1 = new Label();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(332, 78);
            label1.Name = "label1";
            label1.Size = new Size(112, 48);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(225, 165);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(331, 31);
            TxtUserName.TabIndex = 1;
            TxtUserName.TextChanged += TxtUserName_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(225, 222);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(331, 31);
            TxtPassword.TabIndex = 2;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 168);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 228);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(444, 282);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(112, 34);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Controls.Add(label1);
            Name = "LandingPage";
            Text = "LandingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private Label label2;
        private Label label3;
        private Button BtnLogin;
    }
}