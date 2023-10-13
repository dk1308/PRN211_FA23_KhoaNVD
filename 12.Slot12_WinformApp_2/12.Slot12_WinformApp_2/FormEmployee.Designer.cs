namespace _12.Slot12_WinformApp_2
{
    partial class FormEmployee
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
            btnSave = new Button();
            btnCancel = new Button();
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtEmpPhone = new TextBox();
            txtEmpDegree = new TextBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            dgvEmpList = new DataGridView();
            lbTitle = new Label();
            lbEmpId = new Label();
            lbEmpName = new Label();
            lbEmpPhone = new Label();
            lbEmpDegree = new Label();
            lbEmpSex = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpList).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(155, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(322, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(155, 84);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(261, 27);
            txtEmpId.TabIndex = 2;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(155, 148);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(261, 27);
            txtEmpName.TabIndex = 3;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Location = new Point(155, 203);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(261, 27);
            txtEmpPhone.TabIndex = 4;
            // 
            // txtEmpDegree
            // 
            txtEmpDegree.Location = new Point(155, 298);
            txtEmpDegree.Name = "txtEmpDegree";
            txtEmpDegree.Size = new Size(261, 27);
            txtEmpDegree.TabIndex = 5;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(194, 254);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 24);
            rdoMale.TabIndex = 6;
            rdoMale.TabStop = true;
            rdoMale.Text = "male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(298, 254);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(76, 24);
            rdoFemale.TabIndex = 7;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // dgvEmpList
            // 
            dgvEmpList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpList.Location = new Point(471, 73);
            dgvEmpList.Name = "dgvEmpList";
            dgvEmpList.RowHeadersWidth = 51;
            dgvEmpList.RowTemplate.Height = 29;
            dgvEmpList.Size = new Size(300, 327);
            dgvEmpList.TabIndex = 8;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(218, 24);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(125, 20);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Employee Details";
            // 
            // lbEmpId
            // 
            lbEmpId.AutoSize = true;
            lbEmpId.Location = new Point(12, 87);
            lbEmpId.Name = "lbEmpId";
            lbEmpId.Size = new Size(94, 20);
            lbEmpId.TabIndex = 10;
            lbEmpId.Text = "Employee ID";
            // 
            // lbEmpName
            // 
            lbEmpName.AutoSize = true;
            lbEmpName.Location = new Point(12, 151);
            lbEmpName.Name = "lbEmpName";
            lbEmpName.Size = new Size(119, 20);
            lbEmpName.TabIndex = 11;
            lbEmpName.Text = "Employee Name";
            // 
            // lbEmpPhone
            // 
            lbEmpPhone.AutoSize = true;
            lbEmpPhone.Location = new Point(12, 206);
            lbEmpPhone.Name = "lbEmpPhone";
            lbEmpPhone.Size = new Size(120, 20);
            lbEmpPhone.TabIndex = 12;
            lbEmpPhone.Text = "Employee Phone";
            // 
            // lbEmpDegree
            // 
            lbEmpDegree.AutoSize = true;
            lbEmpDegree.Location = new Point(12, 301);
            lbEmpDegree.Name = "lbEmpDegree";
            lbEmpDegree.Size = new Size(128, 20);
            lbEmpDegree.TabIndex = 13;
            lbEmpDegree.Text = "Employee Degree";
            // 
            // lbEmpSex
            // 
            lbEmpSex.AutoSize = true;
            lbEmpSex.Location = new Point(12, 254);
            lbEmpSex.Name = "lbEmpSex";
            lbEmpSex.Size = new Size(127, 20);
            lbEmpSex.TabIndex = 14;
            lbEmpSex.Text = "Employee Gender";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbEmpSex);
            Controls.Add(lbEmpDegree);
            Controls.Add(lbEmpPhone);
            Controls.Add(lbEmpName);
            Controls.Add(lbEmpId);
            Controls.Add(lbTitle);
            Controls.Add(dgvEmpList);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(txtEmpDegree);
            Controls.Add(txtEmpPhone);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "FormEmployee";
            Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)dgvEmpList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtEmpPhone;
        private TextBox txtEmpDegree;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private DataGridView dgvEmpList;
        private Label lbTitle;
        private Label lbEmpId;
        private Label lbEmpName;
        private Label lbEmpPhone;
        private Label lbEmpDegree;
        private Label lbEmpSex;
    }
}