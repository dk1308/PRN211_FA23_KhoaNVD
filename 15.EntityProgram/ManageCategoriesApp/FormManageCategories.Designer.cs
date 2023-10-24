namespace ManageCategoriesApp
{
    partial class FormManageCategories
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
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCategories = new DataGridView();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            lbCategoryID = new Label();
            lbCategoryName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(39, 383);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(207, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(374, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(39, 146);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.Size = new Size(429, 217);
            dgvCategories.TabIndex = 3;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(167, 45);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(310, 27);
            txtCategoryID.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(167, 92);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(310, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(39, 48);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 6;
            lbCategoryID.Text = "Category ID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(39, 95);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(113, 20);
            lbCategoryName.TabIndex = 7;
            lbCategoryName.Text = "Category Name";
            // 
            // FormManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 434);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCategoryID);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(dgvCategories);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Name = "FormManageCategories";
            Text = "Form1";
            Load += FormManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCategories;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private Label lbCategoryID;
        private Label lbCategoryName;
    }
}