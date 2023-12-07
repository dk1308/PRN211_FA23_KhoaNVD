namespace FormEnrollmentDetail
{
    partial class FormEnrollmentDetail
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
            lbStudentId = new Label();
            btnClose = new Button();
            lbCourseId = new Label();
            lbTitle = new Label();
            btnSave = new Button();
            cboStudentId = new ComboBox();
            cboCourseId = new ComboBox();
            SuspendLayout();
            // 
            // lbStudentId
            // 
            lbStudentId.AutoSize = true;
            lbStudentId.Location = new Point(62, 74);
            lbStudentId.Name = "lbStudentId";
            lbStudentId.Size = new Size(79, 20);
            lbStudentId.TabIndex = 5;
            lbStudentId.Text = "Student ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(291, 193);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbCourseId
            // 
            lbCourseId.AutoSize = true;
            lbCourseId.Location = new Point(66, 144);
            lbCourseId.Name = "lbCourseId";
            lbCourseId.Size = new Size(73, 20);
            lbCourseId.TabIndex = 17;
            lbCourseId.Text = "Course ID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(145, 14);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(191, 31);
            lbTitle.TabIndex = 19;
            lbTitle.Text = "Enrollment Detail";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(170, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboStudentId
            // 
            cboStudentId.FormattingEnabled = true;
            cboStudentId.Location = new Point(170, 71);
            cboStudentId.Name = "cboStudentId";
            cboStudentId.Size = new Size(199, 28);
            cboStudentId.TabIndex = 21;
            // 
            // cboCourseId
            // 
            cboCourseId.FormattingEnabled = true;
            cboCourseId.Location = new Point(170, 141);
            cboCourseId.Name = "cboCourseId";
            cboCourseId.Size = new Size(199, 28);
            cboCourseId.TabIndex = 22;
            // 
            // FormEnrollmentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 241);
            Controls.Add(cboCourseId);
            Controls.Add(cboStudentId);
            Controls.Add(btnSave);
            Controls.Add(lbTitle);
            Controls.Add(lbCourseId);
            Controls.Add(btnClose);
            Controls.Add(lbStudentId);
            Name = "FormEnrollmentDetail";
            Text = "FormEnrollment";
            Load += FormEnrollmentDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtStatus;
        private Label lbStudentId;
        private Label lbName;
        private Label lbStatus;
        private DataGridView dgvEnrollment;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Label lbCourseId;
        private TextBox textBox1;
        private Label lbTitle;
        private Button btnSave;
        private ComboBox cboStudentId;
        private ComboBox cboCourseId;
    }
}