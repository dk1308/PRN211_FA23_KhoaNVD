namespace SaleWinApp
{
    partial class FormAdmin
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
            btnMember = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            btnReportStatistic = new Button();
            btnExit = new Button();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // btnMember
            // 
            btnMember.Location = new Point(109, 92);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(275, 29);
            btnMember.TabIndex = 0;
            btnMember.Text = "Member Management";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(109, 156);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(275, 29);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product Management";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(109, 225);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(275, 29);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReportStatistic
            // 
            btnReportStatistic.Location = new Point(109, 289);
            btnReportStatistic.Name = "btnReportStatistic";
            btnReportStatistic.Size = new Size(275, 29);
            btnReportStatistic.TabIndex = 3;
            btnReportStatistic.Text = "Report Statistic Management";
            btnReportStatistic.UseVisualStyleBackColor = true;
            btnReportStatistic.Click += btnReportStatistic_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(384, 344);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 28);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(124, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(238, 35);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "FStore Management";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 375);
            Controls.Add(lbTitle);
            Controls.Add(btnExit);
            Controls.Add(btnReportStatistic);
            Controls.Add(btnOrder);
            Controls.Add(btnProduct);
            Controls.Add(btnMember);
            Name = "FormAdmin";
            Text = "FormAdmin_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMember;
        private Button btnProduct;
        private Button btnOrder;
        private Button btnReportStatistic;
        private Button btnExit;
        private Label lbTitle;
    }
}