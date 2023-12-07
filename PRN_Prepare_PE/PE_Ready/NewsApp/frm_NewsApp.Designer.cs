namespace NewsApp
{
    partial class frm_NewsApp
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
            TxtSearch = new TextBox();
            button1 = new Button();
            Dgv_News = new DataGridView();
            BtnInsert = new Button();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            TxtNewsId = new TextBox();
            label1 = new Label();
            BtnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv_News).BeginInit();
            SuspendLayout();
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(90, 49);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(537, 31);
            TxtSearch.TabIndex = 0;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(633, 46);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dgv_News
            // 
            Dgv_News.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_News.Location = new Point(90, 136);
            Dgv_News.Name = "Dgv_News";
            Dgv_News.RowHeadersWidth = 62;
            Dgv_News.RowTemplate.Height = 33;
            Dgv_News.Size = new Size(655, 240);
            Dgv_News.TabIndex = 2;
            Dgv_News.CellContentClick += Dgv_News_CellContentClick;
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(90, 393);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(112, 34);
            BtnInsert.TabIndex = 3;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(633, 393);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 34);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(350, 393);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(112, 34);
            BtnUpdate.TabIndex = 5;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // TxtNewsId
            // 
            TxtNewsId.Location = new Point(633, 99);
            TxtNewsId.Name = "TxtNewsId";
            TxtNewsId.ReadOnly = true;
            TxtNewsId.Size = new Size(112, 31);
            TxtNewsId.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 102);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 7;
            label1.Text = "News ID:";
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(90, 93);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(112, 34);
            BtnRefresh.TabIndex = 8;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // frm_NewsApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRefresh);
            Controls.Add(label1);
            Controls.Add(TxtNewsId);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnInsert);
            Controls.Add(Dgv_News);
            Controls.Add(button1);
            Controls.Add(TxtSearch);
            Name = "frm_NewsApp";
            Text = "Form1";
            Load += frm_NewsApp_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_News).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSearch;
        private Button button1;
        private DataGridView Dgv_News;
        private Button BtnInsert;
        private Button BtnDelete;
        private Button BtnUpdate;
        private TextBox TxtNewsId;
        private Label label1;
        private Button BtnRefresh;
    }
}