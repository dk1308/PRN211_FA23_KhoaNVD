namespace FormEnrollment
{
    partial class FormEnrollment
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtStatus = new TextBox();
            lbStudentId = new Label();
            lbName = new Label();
            lbStatus = new Label();
            dgvEnrollment = new DataGridView();
            btnDelete = new Button();
            btnClose = new Button();
            lbCourseId = new Label();
            txtCourseId = new TextBox();
            lbTitle = new Label();
            btnAdd = new Button();
            lbDate = new Label();
            dtDateEnroll = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollment).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(108, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(170, 27);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(405, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(405, 114);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(199, 27);
            txtStatus.TabIndex = 4;
            // 
            // lbStudentId
            // 
            lbStudentId.AutoSize = true;
            lbStudentId.Location = new Point(27, 51);
            lbStudentId.Name = "lbStudentId";
            lbStudentId.Size = new Size(79, 20);
            lbStudentId.TabIndex = 5;
            lbStudentId.Text = "Student ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(301, 84);
            lbName.Name = "lbName";
            lbName.Size = new Size(98, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Course Name";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(301, 117);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // dgvEnrollment
            // 
            dgvEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollment.Location = new Point(12, 156);
            dgvEnrollment.Name = "dgvEnrollment";
            dgvEnrollment.RowHeadersWidth = 51;
            dgvEnrollment.RowTemplate.Height = 29;
            dgvEnrollment.Size = new Size(604, 153);
            dgvEnrollment.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(405, 315);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbCourseId
            // 
            lbCourseId.AutoSize = true;
            lbCourseId.Location = new Point(301, 51);
            lbCourseId.Name = "lbCourseId";
            lbCourseId.Size = new Size(73, 20);
            lbCourseId.TabIndex = 17;
            lbCourseId.Text = "Course ID";
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(405, 48);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(199, 27);
            txtCourseId.TabIndex = 16;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(241, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(131, 31);
            lbTitle.TabIndex = 19;
            lbTitle.Text = "Enrollment ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(151, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(27, 88);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(83, 20);
            lbDate.TabIndex = 21;
            lbDate.Text = "Date Enroll";
            // 
            // dtDateEnroll
            // 
            dtDateEnroll.Location = new Point(108, 83);
            dtDateEnroll.Name = "dtDateEnroll";
            dtDateEnroll.Size = new Size(170, 27);
            dtDateEnroll.TabIndex = 22;
            // 
            // FormEnrollment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 359);
            Controls.Add(dtDateEnroll);
            Controls.Add(lbDate);
            Controls.Add(btnAdd);
            Controls.Add(lbTitle);
            Controls.Add(lbCourseId);
            Controls.Add(txtCourseId);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(dgvEnrollment);
            Controls.Add(lbStatus);
            Controls.Add(lbName);
            Controls.Add(lbStudentId);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "FormEnrollment";
            Text = "FormEnrollment";
            Load += FormEnrollment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnrollment).EndInit();
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
        private Button btnDelete;
        private Button btnClose;
        private Label lbCourseId;
        private TextBox txtCourseId;
        private Label lbTitle;
        private Button btnAdd;
        private Label lbDate;
        private DateTimePicker dtDateEnroll;
    }
}