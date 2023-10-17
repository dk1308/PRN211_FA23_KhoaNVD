namespace DemoDataProviderWinform;

partial class FormProduct
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
        btnViewProducts = new Button();
        btnViewCategories = new Button();
        btnClose = new Button();
        dgvList = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
        SuspendLayout();
        // 
        // btnViewProducts
        // 
        btnViewProducts.Location = new Point(64, 35);
        btnViewProducts.Name = "btnViewProducts";
        btnViewProducts.Size = new Size(139, 29);
        btnViewProducts.TabIndex = 0;
        btnViewProducts.Text = "View Products";
        btnViewProducts.UseVisualStyleBackColor = true;
        btnViewProducts.Click += btnViewProducts_Click;
        // 
        // btnViewCategories
        // 
        btnViewCategories.Location = new Point(415, 35);
        btnViewCategories.Name = "btnViewCategories";
        btnViewCategories.Size = new Size(141, 29);
        btnViewCategories.TabIndex = 1;
        btnViewCategories.Text = "View Categories";
        btnViewCategories.UseVisualStyleBackColor = true;
        btnViewCategories.Click += btnViewCategories_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(267, 409);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(94, 29);
        btnClose.TabIndex = 2;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // dgvList
        // 
        dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvList.Location = new Point(12, 82);
        dgvList.Name = "dgvList";
        dgvList.RowHeadersWidth = 51;
        dgvList.RowTemplate.Height = 29;
        dgvList.Size = new Size(602, 321);
        dgvList.TabIndex = 3;
        // 
        // FormProduct
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(626, 450);
        Controls.Add(dgvList);
        Controls.Add(btnClose);
        Controls.Add(btnViewCategories);
        Controls.Add(btnViewProducts);
        Name = "FormProduct";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
        ResumeLayout(false);
    }


    #endregion

    private Button btnViewProducts;
    private Button btnViewCategories;
    private Button btnClose;
    private DataGridView dgvList;
}