namespace SaleWinApp
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            lbTitle = new Label();
            lbMemberID = new Label();
            lbFrieght = new Label();
            lbQuantity = new Label();
            lbRequiredDate = new Label();
            lbShipDate = new Label();
            lbDiscount = new Label();
            dgvProductList = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtMemberID = new TextBox();
            txtFreight = new TextBox();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            lbProductID = new Label();
            txtProductID = new TextBox();
            dtRequiredDate = new DateTimePicker();
            dtShippedDate = new DateTimePicker();
            dgvOrderDetailList = new DataGridView();
            lbInfo = new Label();
            txtTotalMoney = new TextBox();
            lbTotalMoney = new Label();
            btnAddProduct = new Button();
            label1 = new Label();
            label2 = new Label();
            btnViewOrderDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(244, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(234, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Order Management";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(33, 369);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "Member ID";
            // 
            // lbFrieght
            // 
            lbFrieght.AutoSize = true;
            lbFrieght.Location = new Point(33, 425);
            lbFrieght.Name = "lbFrieght";
            lbFrieght.Size = new Size(55, 20);
            lbFrieght.TabIndex = 2;
            lbFrieght.Text = "Freight";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(33, 110);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Quantity";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(318, 369);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(105, 20);
            lbRequiredDate.TabIndex = 4;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbShipDate
            // 
            lbShipDate.AutoSize = true;
            lbShipDate.Location = new Point(323, 425);
            lbShipDate.Name = "lbShipDate";
            lbShipDate.Size = new Size(100, 20);
            lbShipDate.TabIndex = 5;
            lbShipDate.Text = "Shipped Date";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(318, 110);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 6;
            lbDiscount.Text = "Discount";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 140);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(706, 158);
            dgvProductList.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(244, 568);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(418, 568);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(626, 671);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(123, 366);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(164, 27);
            txtMemberID.TabIndex = 12;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(123, 422);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(164, 27);
            txtFreight.TabIndex = 13;
            txtFreight.TextChanged += txtFreight_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(123, 107);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(164, 27);
            txtQuantity.TabIndex = 14;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(437, 107);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(255, 27);
            txtDiscount.TabIndex = 17;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(123, 58);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(164, 27);
            txtOrderID.TabIndex = 18;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(33, 61);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(66, 20);
            lbOrderID.TabIndex = 19;
            lbOrderID.Text = "Order ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(318, 61);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 23;
            lbProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(437, 58);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(255, 27);
            txtProductID.TabIndex = 22;
            // 
            // dtRequiredDate
            // 
            dtRequiredDate.Location = new Point(437, 364);
            dtRequiredDate.Name = "dtRequiredDate";
            dtRequiredDate.Size = new Size(255, 27);
            dtRequiredDate.TabIndex = 24;
            // 
            // dtShippedDate
            // 
            dtShippedDate.Location = new Point(437, 420);
            dtShippedDate.Name = "dtShippedDate";
            dtShippedDate.Size = new Size(255, 27);
            dtShippedDate.TabIndex = 25;
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(12, 455);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 29;
            dgvOrderDetailList.Size = new Size(708, 107);
            dgvOrderDetailList.TabIndex = 26;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbInfo.Location = new Point(60, 623);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(171, 28);
            lbInfo.TabIndex = 27;
            lbInfo.Text = "Order Information";
            // 
            // txtTotalMoney
            // 
            txtTotalMoney.Location = new Point(466, 627);
            txtTotalMoney.Name = "txtTotalMoney";
            txtTotalMoney.Size = new Size(198, 27);
            txtTotalMoney.TabIndex = 29;
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.Location = new Point(350, 630);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(91, 20);
            lbTotalMoney.TabIndex = 31;
            lbTotalMoney.Text = "Total Money";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(323, 304);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 32;
            btnAddProduct.Text = "Add ";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 336);
            label1.Name = "label1";
            label1.Size = new Size(666, 20);
            label1.TabIndex = 33;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 600);
            label2.Name = "label2";
            label2.Size = new Size(666, 20);
            label2.TabIndex = 34;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnViewOrderDetails
            // 
            btnViewOrderDetails.Location = new Point(244, 671);
            btnViewOrderDetails.Name = "btnViewOrderDetails";
            btnViewOrderDetails.Size = new Size(268, 29);
            btnViewOrderDetails.TabIndex = 35;
            btnViewOrderDetails.Text = "View all order details ?";
            btnViewOrderDetails.UseVisualStyleBackColor = true;
            btnViewOrderDetails.Click += btnViewOrderDetails_Click;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 707);
            Controls.Add(btnViewOrderDetails);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddProduct);
            Controls.Add(lbTotalMoney);
            Controls.Add(txtTotalMoney);
            Controls.Add(lbInfo);
            Controls.Add(dgvOrderDetailList);
            Controls.Add(dtShippedDate);
            Controls.Add(dtRequiredDate);
            Controls.Add(lbProductID);
            Controls.Add(txtProductID);
            Controls.Add(lbOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberID);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductList);
            Controls.Add(lbDiscount);
            Controls.Add(lbShipDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbQuantity);
            Controls.Add(lbFrieght);
            Controls.Add(lbMemberID);
            Controls.Add(lbTitle);
            Name = "FormOrder";
            Text = "FormMember";
            Load += FormOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbMemberID;
        private Label lbFrieght;
        private Label lbQuantity;
        private Label lbRequiredDate;
        private Label lbShipDate;
        private Label lbDiscount;
        private DataGridView dgvProductList;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtMemberID;
        private TextBox txtFreight;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private TextBox txtOrderID;
        private Label lbOrderID;
        private Label lbProductID;
        private TextBox txtProductID;
        private DateTimePicker dtRequiredDate;
        private DateTimePicker dtShippedDate;
        private DataGridView dgvOrderDetailList;
        private Label lbInfo;
        private TextBox txtTotalMoney;
        private Label lbTotalMoney;
        private Button btnAddProduct;
        private Label label1;
        private Label label2;
        private Button btnViewOrderDetails;
    }
}
