namespace FPTUniversityWinApp
{
    partial class FormAddOrUpload
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
            txtDoctorId = new TextBox();
            txtName = new TextBox();
            lbDoctorId = new Label();
            lbName = new Label();
            lbAddress = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            lbTitle = new Label();
            cboSpecialization = new ComboBox();
            lbSpecialization = new Label();
            SuspendLayout();
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(186, 84);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(199, 27);
            txtDoctorId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 3;
            // 
            // lbDoctorId
            // 
            lbDoctorId.AutoSize = true;
            lbDoctorId.Location = new Point(60, 87);
            lbDoctorId.Name = "lbDoctorId";
            lbDoctorId.Size = new Size(70, 20);
            lbDoctorId.TabIndex = 5;
            lbDoctorId.Text = "DoctorID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(60, 120);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(60, 157);
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
            // cboSpecialization
            // 
            cboSpecialization.FormattingEnabled = true;
            cboSpecialization.Items.AddRange(new object[] { "Internal Medicine", "Pediatrics", "Dentistry" });
            cboSpecialization.Location = new Point(186, 196);
            cboSpecialization.Name = "cboSpecialization";
            cboSpecialization.Size = new Size(199, 28);
            cboSpecialization.TabIndex = 17;
            // 
            // lbSpecialization
            // 
            lbSpecialization.AutoSize = true;
            lbSpecialization.Location = new Point(60, 199);
            lbSpecialization.Name = "lbSpecialization";
            lbSpecialization.Size = new Size(102, 20);
            lbSpecialization.TabIndex = 16;
            lbSpecialization.Text = "Specialization";
            // 
            // FormAddOrUpload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 308);
            Controls.Add(cboSpecialization);
            Controls.Add(lbSpecialization);
            Controls.Add(lbTitle);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lbAddress);
            Controls.Add(txtAddress);
            Controls.Add(lbName);
            Controls.Add(lbDoctorId);
            Controls.Add(txtName);
            Controls.Add(txtDoctorId);
            Name = "FormAddOrUpload";
            Text = "FormStudent";
            Load += FormAddOrUpload_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDoctorId;
        private TextBox txtName;
        private Label lbDoctorId;
        private Label lbName;
        private Label lbAddress;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnClose;
        private Label lbTitle;
        private ComboBox cboSpecialization;
        private Label lbSpecialization;
    }
}