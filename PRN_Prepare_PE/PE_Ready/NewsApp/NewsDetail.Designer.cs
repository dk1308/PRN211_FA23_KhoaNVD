namespace NewsApp
{
    partial class NewsDetail
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
            CbCategory = new ComboBox();
            txtTitles = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CbStatus = new ComboBox();
            TxtDateUpdate = new TextBox();
            label6 = new Label();
            BtnUpdate = new Button();
            BtnInsert = new Button();
            SuspendLayout();
            // 
            // CbCategory
            // 
            CbCategory.FormattingEnabled = true;
            CbCategory.Location = new Point(188, 178);
            CbCategory.Name = "CbCategory";
            CbCategory.Size = new Size(429, 33);
            CbCategory.TabIndex = 0;
            CbCategory.SelectedIndexChanged += CbCategory_SelectedIndexChanged;
            // 
            // txtTitles
            // 
            txtTitles.Location = new Point(188, 117);
            txtTitles.Name = "txtTitles";
            txtTitles.Size = new Size(429, 31);
            txtTitles.TabIndex = 1;
            txtTitles.TextChanged += textBox1_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(188, 239);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(429, 31);
            txtDescription.TabIndex = 2;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 47);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 4;
            label1.Text = "New Detail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 181);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 120);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 6;
            label3.Text = "Titles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 242);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 298);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // CbStatus
            // 
            CbStatus.FormattingEnabled = true;
            CbStatus.Location = new Point(188, 295);
            CbStatus.Name = "CbStatus";
            CbStatus.Size = new Size(429, 33);
            CbStatus.TabIndex = 9;
            CbStatus.SelectedIndexChanged += CbStatus_SelectedIndexChanged;
            // 
            // TxtDateUpdate
            // 
            TxtDateUpdate.Location = new Point(188, 353);
            TxtDateUpdate.Name = "TxtDateUpdate";
            TxtDateUpdate.ReadOnly = true;
            TxtDateUpdate.Size = new Size(429, 31);
            TxtDateUpdate.TabIndex = 10;
            TxtDateUpdate.TextChanged += TxtDateUpdate_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 356);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 11;
            label6.Text = "Date Update";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(353, 404);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(112, 34);
            BtnUpdate.TabIndex = 12;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(505, 404);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(112, 34);
            BtnInsert.TabIndex = 13;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // NewsDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnInsert);
            Controls.Add(BtnUpdate);
            Controls.Add(label6);
            Controls.Add(TxtDateUpdate);
            Controls.Add(CbStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtTitles);
            Controls.Add(CbCategory);
            Name = "NewsDetail";
            Text = "NewsDetail";
            Load += NewsDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbCategory;
        private TextBox txtTitles;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CbStatus;
        private TextBox TxtDateUpdate;
        private Label label6;
        private Button BtnUpdate;
        private Button BtnInsert;
    }
}