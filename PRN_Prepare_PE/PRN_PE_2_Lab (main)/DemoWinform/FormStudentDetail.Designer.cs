namespace FormStudentDetail
{
    partial class FormStudentDetail
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtStatus = new TextBox();
            lbId = new Label();
            lbName = new Label();
            lbStatus = new Label();
            lbAddress = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(186, 84);
            txtId.Name = "txtId";
            txtId.Size = new Size(199, 27);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(186, 187);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(199, 27);
            txtStatus.TabIndex = 4;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(113, 87);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 5;
            lbId.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(113, 120);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(113, 190);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(113, 157);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 10;
            lbAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(186, 154);
            txtAddress.Name = "txtAddress";
            txtAddress.ShortcutsEnabled = false;
            txtAddress.Size = new Size(199, 27);
            txtAddress.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(308, 246);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(77, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(173, 32);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(159, 31);
            lbTitle.TabIndex = 15;
            lbTitle.Text = "Student Detail";
            // 
            // FormStudentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 308);
            Controls.Add(lbTitle);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lbAddress);
            Controls.Add(txtAddress);
            Controls.Add(lbStatus);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "FormStudentDetail";
            Text = "FormStudent";
            Load += FormStudentDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtStatus;
        private Label lbId;
        private Label lbName;
        private Label lbStatus;
        private Label lbAddress;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnClose;
        private Label lbTitle;
    }
}