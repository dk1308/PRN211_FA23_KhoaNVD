namespace SaleWinApp
{
    partial class FormUserOrder
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
            lbMemberID = new Label();
            lbFrieght = new Label();
            lbQuantity = new Label();
            lbRequiredDate = new Label();
            lbShipDate = new Label();
            lbDiscount = new Label();
            btnUpdate = new Button();
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
            label1 = new Label();
            label2 = new Label();
            dtOrderDate = new DateTimePicker();
            lbOrderDate = new Label();
            dtEndDate = new DateTimePicker();
            dtStartDate = new DateTimePicker();
            lbEndDate = new Label();
            lbStartDate = new Label();
            txtTotalMoney2 = new TextBox();
            lbTotalMoney = new Label();
            btnSearch = new Button();
            label3 = new Label();
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
            lbMemberID.Location = new Point(33, 163);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "Member ID";
            // 
            // lbFrieght
            // 
            lbFrieght.AutoSize = true;
            lbFrieght.Location = new Point(33, 219);
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
            lbRequiredDate.Location = new Point(318, 163);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(105, 20);
            lbRequiredDate.TabIndex = 4;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbShipDate
            // 
            lbShipDate.AutoSize = true;
            lbShipDate.Location = new Point(323, 219);
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
            // btnUpdate
            // 
            btnUpdate.Location = new Point(209, 493);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(421, 493);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(626, 635);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(123, 160);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(164, 27);
            txtMemberID.TabIndex = 12;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(123, 216);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(164, 27);
            txtFreight.TabIndex = 13;
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
            txtOrderID.TextChanged += txtOrderID_TextChanged;
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
            dtRequiredDate.Location = new Point(437, 158);
            dtRequiredDate.Name = "dtRequiredDate";
            dtRequiredDate.Size = new Size(255, 27);
            dtRequiredDate.TabIndex = 24;
            // 
            // dtShippedDate
            // 
            dtShippedDate.Location = new Point(437, 214);
            dtShippedDate.Name = "dtShippedDate";
            dtShippedDate.Size = new Size(255, 27);
            dtShippedDate.TabIndex = 25;
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(12, 292);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 29;
            dgvOrderDetailList.Size = new Size(708, 195);
            dgvOrderDetailList.TabIndex = 26;
            dgvOrderDetailList.CellContentClick += dgvOrderDetailList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 336);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 600);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 34;
            // 
            // dtOrderDate
            // 
            dtOrderDate.Location = new Point(298, 260);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(255, 27);
            dtOrderDate.TabIndex = 36;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(184, 265);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(100, 20);
            lbOrderDate.TabIndex = 35;
            lbOrderDate.Text = "Ordered Date";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(142, 576);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(255, 27);
            dtEndDate.TabIndex = 40;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(142, 543);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(255, 27);
            dtStartDate.TabIndex = 39;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(23, 580);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(70, 20);
            lbEndDate.TabIndex = 38;
            lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(23, 548);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(76, 20);
            lbStartDate.TabIndex = 37;
            lbStartDate.Text = "Start Date";
            // 
            // txtTotalMoney2
            // 
            txtTotalMoney2.Location = new Point(142, 631);
            txtTotalMoney2.Name = "txtTotalMoney2";
            txtTotalMoney2.Size = new Size(400, 27);
            txtTotalMoney2.TabIndex = 42;
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.Location = new Point(45, 634);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(91, 20);
            lbTotalMoney.TabIndex = 41;
            lbTotalMoney.Text = "Total Money";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(448, 558);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 520);
            label3.Name = "label3";
            label3.Size = new Size(579, 20);
            label3.TabIndex = 44;
            label3.Text = "..............................................................................................................................................................................................";
            // 
            // FormUserOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 676);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtTotalMoney2);
            Controls.Add(lbTotalMoney);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(lbEndDate);
            Controls.Add(lbStartDate);
            Controls.Add(dtOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Controls.Add(btnUpdate);
            Controls.Add(lbDiscount);
            Controls.Add(lbShipDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbQuantity);
            Controls.Add(lbFrieght);
            Controls.Add(lbMemberID);
            Controls.Add(lbTitle);
            Name = "FormUserOrder";
            Text = "FormMember";
            Load += FormListOrder_Load;
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
        private Button btnUpdate;
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
        private DateTimePicker dtOrderDate;
        private Label lbOrderDate;
        private DateTimePicker dtEndDate;
        private DateTimePicker dtStartDate;
        private Label lbEndDate;
        private Label lbStartDate;
        private TextBox txtTotalMoney2;
        private Button btnSearch;
        private Label label3;
    }
}