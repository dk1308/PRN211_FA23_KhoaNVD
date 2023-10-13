namespace _12.Slot12_WinformApp_2
{
    partial class FormDGV
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
            dgvStudentList = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(104, 136);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.RowTemplate.Height = 29;
            dgvStudentList.Size = new Size(593, 223);
            dgvStudentList.TabIndex = 0;
            dgvStudentList.CellContentClick += dgvStudentList_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "button1";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(169, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FormDGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvStudentList);
            Name = "FormDGV";
            Text = "Form1";
            Load += FormDGVLoad;
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentList;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}