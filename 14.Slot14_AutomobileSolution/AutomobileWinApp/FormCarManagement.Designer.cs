namespace AutomobileWinApp
{
    partial class FormCarManagement
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
            btnLoad = new Button();
            btnNew = new Button();
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            txtPrice = new TextBox();
            txtManufacturer = new TextBox();
            txtReleaseYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonShadow;
            btnLoad.Location = new Point(145, 211);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.AppWorkspace;
            btnNew.Location = new Point(386, 211);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(37, 47);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 2;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(37, 100);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 3;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(37, 146);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 4;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(469, 47);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(469, 100);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(101, 20);
            lbReleaseYear.TabIndex = 6;
            lbReleaseYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(160, 44);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(210, 27);
            txtCarID.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(160, 97);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(210, 27);
            txtCarName.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnDelete.Location = new Point(617, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(13, 269);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.Size = new Size(810, 210);
            dgvCarList.TabIndex = 13;
            dgvCarList.CellContentClick += dgvCarList_CellContentClick_1;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.AppWorkspace;
            btnClose.Location = new Point(386, 485);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(594, 44);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(210, 27);
            txtPrice.TabIndex = 15;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(160, 143);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(210, 27);
            txtManufacturer.TabIndex = 16;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(594, 97);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(210, 27);
            txtReleaseYear.TabIndex = 17;
            // 
            // FormCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 517);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtPrice);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Name = "FormCarManagement";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnNew;
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
        private TextBox txtPrice;
        private TextBox txtManufacturer;
        private TextBox txtReleaseYear;
    }
}
