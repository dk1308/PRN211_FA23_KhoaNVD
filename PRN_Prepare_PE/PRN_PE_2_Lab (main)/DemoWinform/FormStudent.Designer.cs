namespace FormStudent
{
    partial class FormStudent
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtStatus = new TextBox();
            lbId = new Label();
            lbName = new Label();
            lbStatus = new Label();
            dgvStudent = new DataGridView();
            lbAddress = new Label();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(361, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(516, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(199, 27);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(107, 141);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(199, 27);
            txtStatus.TabIndex = 4;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(34, 41);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 5;
            lbId.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(34, 74);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(34, 144);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(12, 191);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(604, 184);
            dgvStudent.TabIndex = 8;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(34, 111);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 10;
            lbAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(107, 108);
            txtAddress.Name = "txtAddress";
            txtAddress.ShortcutsEnabled = false;
            txtAddress.Size = new Size(199, 27);
            txtAddress.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(75, 381);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(281, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(488, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(281, 419);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lbAddress);
            Controls.Add(txtAddress);
            Controls.Add(dgvStudent);
            Controls.Add(lbStatus);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "FormStudent";
            Text = "FormStudent";
            Load += FormStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtStatus;
        private Label lbId;
        private Label lbName;
        private Label lbStatus;
        private DataGridView dgvStudent;
        private Label lbAddress;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
    }
}