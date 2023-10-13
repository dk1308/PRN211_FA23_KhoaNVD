namespace _11.Slot11_Lab
{
    partial class FormCalculator
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
            val1 = new TextBox();
            val2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addBtn = new Button();
            subBtn = new Button();
            mulBtn = new Button();
            divBtn = new Button();
            delBtn = new Button();
            label3 = new Label();
            result = new TextBox();
            SuspendLayout();
            // 
            // val1
            // 
            val1.Location = new Point(158, 36);
            val1.Name = "val1";
            val1.Size = new Size(252, 27);
            val1.TabIndex = 0;
            val1.TextChanged += textBox1_TextChanged;
            val1.KeyPress += Val1_KeyPress;
            // 
            // val2
            // 
            val2.Location = new Point(158, 83);
            val2.Name = "val2";
            val2.Size = new Size(252, 27);
            val2.TabIndex = 1;
            val2.TextChanged += textBox2_TextChanged;
            val2.KeyPress += Val2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Số thứ hai";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(38, 150);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(59, 29);
            addBtn.TabIndex = 4;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += button1_Click;
            // 
            // subBtn
            // 
            subBtn.Location = new Point(124, 150);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(55, 29);
            subBtn.TabIndex = 5;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += button2_Click;
            // 
            // mulBtn
            // 
            mulBtn.Location = new Point(207, 150);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(55, 29);
            mulBtn.TabIndex = 6;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = true;
            mulBtn.Click += button3_Click;
            // 
            // divBtn
            // 
            divBtn.Location = new Point(298, 150);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(56, 29);
            divBtn.TabIndex = 10;
            divBtn.Text = "%";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.TextChanged += textBox3_TextChanged;
            divBtn.Click += divBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(386, 150);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(53, 29);
            delBtn.TabIndex = 11;
            delBtn.Text = "del";
            delBtn.Click += delBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 204);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Kết quả";
            // 
            // result
            // 
            result.Location = new Point(158, 201);
            result.Name = "result";
            result.Size = new Size(252, 27);
            result.TabIndex = 0;
            result.TextChanged += result_TextChanged;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 261);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(addBtn);
            Controls.Add(subBtn);
            Controls.Add(mulBtn);
            Controls.Add(divBtn);
            Controls.Add(delBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(val1);
            Controls.Add(val2);
            Name = "FormCalculator";
            Text = "FormCalculator";
            Load += FormCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox val1;
        private TextBox val2;
        private Label label1;
        private Label label2;
        private Button addBtn;
        private Button subBtn;
        private Button mulBtn;
        private Button divBtn;
        private Button delBtn;
        private Label label3;
        private TextBox result;
    }
}