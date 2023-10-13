namespace lab5
{
    partial class Form_Load : Form
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
            fullName = new TextBox();
            showBtn = new Button();
            exitBtn = new Button();
            fullNamelb = new Label();
            SuspendLayout();
            // 
            // fullNamelb
            // 
            fullNamelb.AutoSize = true;
            fullNamelb.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            fullNamelb.Location = new Point(159, 27);
            fullNamelb.Name = "label6";
            fullNamelb.Size = new Size(514, 67);
            fullNamelb.TabIndex = 12;
            fullNamelb.Text = "Full Name";
            fullNamelb.Click += fullNamelb_Click;
            // 
            // fullName
            // 
            fullName.Location = new Point(217, 140);
            fullName.Name = "fullName";
            fullName.Size = new Size(318, 27);
            fullName.TabIndex = 0;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(217, 233);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(113, 45);
            showBtn.TabIndex = 13;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(421, 233);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(114, 45);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form_Load
            // 
            ClientSize = new Size(777, 405);
            Controls.Add(fullNamelb);
            Controls.Add(fullName);
            Controls.Add(showBtn);
            Controls.Add(exitBtn);
            Name = "Form_Load";
            Load += FormLoad_Load;

            // Set Key events
            KeyPreview = true;
            KeyDown += KeyDown_Event;

            // Set Mouse events
            MouseDown += FormLoad_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label fullNamelb;
        private TextBox fullName;
        private Button showBtn;
        private Button exitBtn;
        #endregion
    }
}