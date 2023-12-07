namespace FormStudent
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
            btnStudent = new Button();
            btnEnrollment = new Button();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(91, 97);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(178, 29);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Manage Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnEnrollment
            // 
            btnEnrollment.Location = new Point(91, 188);
            btnEnrollment.Name = "btnEnrollment";
            btnEnrollment.Size = new Size(178, 29);
            btnEnrollment.TabIndex = 1;
            btnEnrollment.Text = "Manage Enrollment";
            btnEnrollment.UseVisualStyleBackColor = true;
            btnEnrollment.Click += btnEnrollment_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 283);
            Controls.Add(btnEnrollment);
            Controls.Add(btnStudent);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudent;
        private Button btnEnrollment;
    }
}