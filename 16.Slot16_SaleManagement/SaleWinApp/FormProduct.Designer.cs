namespace SaleWinApp
{
    partial class FormProduct
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
            lbTitle = new Label();
            lbID = new Label();
            lbCategoryID = new Label();
            lbProductName = new Label();
            lbWeight = new Label();
            lbUnitPrice = new Label();
            lbUnitsInStock = new Label();
            dgvProductList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtID = new TextBox();
            txtCategoryID = new TextBox();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtValue = new TextBox();
            btnSearch = new Button();
            lbCriteria = new Label();
            cboCriteria = new ComboBox();
            label2 = new Label();
            lbValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(173, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(256, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Product Management";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(36, 153);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(36, 204);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 2;
            lbCategoryID.Text = "Category ID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(36, 255);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(49, 20);
            lbProductName.TabIndex = 3;
            lbProductName.Text = "Name";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(329, 153);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 4;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(329, 204);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 5;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(329, 255);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(98, 20);
            lbUnitsInStock.TabIndex = 6;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 334);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(598, 227);
            dgvProductList.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(96, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(263, 299);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(435, 299);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(263, 570);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 150);
            txtID.Name = "txtID";
            txtID.Size = new Size(160, 27);
            txtID.TabIndex = 12;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(130, 201);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(160, 27);
            txtCategoryID.TabIndex = 13;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(130, 252);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(160, 27);
            txtProductName.TabIndex = 14;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(433, 150);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(156, 27);
            txtWeight.TabIndex = 15;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(433, 201);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(156, 27);
            txtUnitPrice.TabIndex = 16;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(433, 252);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(156, 27);
            txtUnitsInStock.TabIndex = 17;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(205, 92);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(180, 27);
            txtValue.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(396, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbCriteria
            // 
            lbCriteria.AutoSize = true;
            lbCriteria.Location = new Point(96, 60);
            lbCriteria.Name = "lbCriteria";
            lbCriteria.Size = new Size(103, 20);
            lbCriteria.TabIndex = 18;
            lbCriteria.Text = "Search criteria";
            // 
            // cboCriteria
            // 
            cboCriteria.DisplayMember = "ProductID";
            cboCriteria.FormattingEnabled = true;
            cboCriteria.Items.AddRange(new object[] { "ProductID", "ProductName", "UnitPrice", "UnitInStock", "All" });
            cboCriteria.Location = new Point(205, 57);
            cboCriteria.Name = "cboCriteria";
            cboCriteria.Size = new Size(180, 28);
            cboCriteria.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 122);
            label2.Name = "label2";
            label2.Size = new Size(579, 20);
            label2.TabIndex = 22;
            label2.Text = "..............................................................................................................................................................................................";
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(96, 95);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(45, 20);
            lbValue.TabIndex = 23;
            lbValue.Text = "Value";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 608);
            Controls.Add(lbValue);
            Controls.Add(label2);
            Controls.Add(cboCriteria);
            Controls.Add(txtValue);
            Controls.Add(btnSearch);
            Controls.Add(lbCriteria);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtID);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductList);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbProductName);
            Controls.Add(lbCategoryID);
            Controls.Add(lbID);
            Controls.Add(lbTitle);
            Name = "FormProduct";
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbID;
        private Label lbCategoryID;
        private Label lbProductName;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitsInStock;
        private DataGridView dgvProductList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtID;
        private TextBox txtCategoryID;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtValue;
        private Button btnSearch;
        private Label lbCriteria;
        private ComboBox cboCriteria;
        private Label label2;
        private Label lbValue;
    }
}