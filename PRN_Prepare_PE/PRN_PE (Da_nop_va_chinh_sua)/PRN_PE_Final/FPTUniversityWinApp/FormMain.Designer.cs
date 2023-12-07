namespace FPTUniversityWinApp
{
    partial class FormMain
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
            dgvDoctorList = new DataGridView();
            lbSpecialization = new Label();
            txtAddress = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cboSpecialization = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoctorList).BeginInit();
            SuspendLayout();
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(214, 23);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(368, 27);
            txtDoctorId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(368, 27);
            txtName.TabIndex = 3;
            // 
            // lbDoctorId
            // 
            lbDoctorId.AutoSize = true;
            lbDoctorId.Location = new Point(39, 26);
            lbDoctorId.Name = "lbDoctorId";
            lbDoctorId.Size = new Size(70, 20);
            lbDoctorId.TabIndex = 5;
            lbDoctorId.Text = "DoctorID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(39, 72);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(39, 161);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 7;
            lbAddress.Text = "Address";
            // 
            // dgvDoctorList
            // 
            dgvDoctorList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctorList.Location = new Point(12, 204);
            dgvDoctorList.Name = "dgvDoctorList";
            dgvDoctorList.RowHeadersWidth = 51;
            dgvDoctorList.RowTemplate.Height = 29;
            dgvDoctorList.Size = new Size(604, 184);
            dgvDoctorList.TabIndex = 8;
            // 
            // lbSpecialization
            // 
            lbSpecialization.AutoSize = true;
            lbSpecialization.Location = new Point(39, 116);
            lbSpecialization.Name = "lbSpecialization";
            lbSpecialization.Size = new Size(102, 20);
            lbSpecialization.TabIndex = 10;
            lbSpecialization.Text = "Specialization";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(214, 158);
            txtAddress.Name = "txtAddress";
            txtAddress.ShortcutsEnabled = false;
            txtAddress.Size = new Size(368, 27);
            txtAddress.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(75, 409);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(270, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(473, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cboSpecialization
            // 
            cboSpecialization.FormattingEnabled = true;
            cboSpecialization.Items.AddRange(new object[] { "Internal Medicine", "Pediatrics", "Dentistry" });
            cboSpecialization.Location = new Point(214, 113);
            cboSpecialization.Name = "cboSpecialization";
            cboSpecialization.Size = new Size(368, 28);
            cboSpecialization.TabIndex = 14;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(cboSpecialization);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lbSpecialization);
            Controls.Add(txtAddress);
            Controls.Add(dgvDoctorList);
            Controls.Add(lbAddress);
            Controls.Add(lbName);
            Controls.Add(lbDoctorId);
            Controls.Add(txtName);
            Controls.Add(txtDoctorId);
            Name = "FormMain";
            Text = "FormStudent";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctorList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtDoctorId;
        private TextBox txtName;
        private Label lbDoctorId;
        private Label lbName;
        private Label lbAddress;
        private DataGridView dgvDoctorList;
        private Label lbSpecialization;
        private TextBox txtAddress;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cboSpecialization;
    }
}