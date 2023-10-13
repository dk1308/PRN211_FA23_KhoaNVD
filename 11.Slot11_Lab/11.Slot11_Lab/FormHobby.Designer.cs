namespace _11.Slot11_Lab
{
    partial class FormHobby
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
            hobbyBox = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            colorBox = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            hobbyBtn = new Button();
            colorBtn = new Button();
            hobbyBox.SuspendLayout();
            colorBox.SuspendLayout();
            SuspendLayout();
            // 
            // hobbyBox
            // 
            hobbyBox.Controls.Add(checkBox5);
            hobbyBox.Controls.Add(checkBox4);
            hobbyBox.Controls.Add(checkBox3);
            hobbyBox.Controls.Add(checkBox2);
            hobbyBox.Controls.Add(checkBox1);
            hobbyBox.Location = new Point(28, 44);
            hobbyBox.Name = "hobbyBox";
            hobbyBox.Size = new Size(198, 197);
            hobbyBox.TabIndex = 0;
            hobbyBox.TabStop = false;
            hobbyBox.Text = "Sở thích của bạn";
            hobbyBox.Enter += groupBox1_Enter;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 160);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(77, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Du lịch";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 130);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(91, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Mua sắm";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 100);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(120, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Chơi thể thao";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Xem phim";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Nghe nhạc";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // colorBox
            // 
            colorBox.Controls.Add(radioButton6);
            colorBox.Controls.Add(radioButton5);
            colorBox.Controls.Add(radioButton3);
            colorBox.Controls.Add(radioButton2);
            colorBox.Controls.Add(radioButton1);
            colorBox.Location = new Point(267, 44);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(206, 197);
            colorBox.TabIndex = 1;
            colorBox.TabStop = false;
            colorBox.Text = "Màu bạn thích";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 159);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(58, 24);
            radioButton6.TabIndex = 4;
            radioButton6.TabStop = true;
            radioButton6.Text = "Lam";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 129);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(52, 24);
            radioButton5.TabIndex = 3;
            radioButton5.TabStop = true;
            radioButton5.Text = "Lục";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vàng";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cam";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Đỏ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // hobbyBtn
            // 
            hobbyBtn.Location = new Point(46, 257);
            hobbyBtn.Name = "hobbyBtn";
            hobbyBtn.Size = new Size(148, 48);
            hobbyBtn.TabIndex = 2;
            hobbyBtn.Text = "Sở thích của bạn";
            hobbyBtn.UseVisualStyleBackColor = true;
            hobbyBtn.Click += hobbyBtn_Click;
            // 
            // colorBtn
            // 
            colorBtn.Location = new Point(301, 257);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(148, 48);
            colorBtn.TabIndex = 3;
            colorBtn.Text = "Màu bạn thích";
            colorBtn.UseVisualStyleBackColor = true;
            colorBtn.Click += colorBtn_Click;
            // 
            // FormHobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 326);
            Controls.Add(colorBtn);
            Controls.Add(hobbyBtn);
            Controls.Add(colorBox);
            Controls.Add(hobbyBox);
            Name = "FormHobby";
            Text = "FormHobby";
            hobbyBox.ResumeLayout(false);
            hobbyBox.PerformLayout();
            colorBox.ResumeLayout(false);
            colorBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox hobbyBox;
        private GroupBox colorBox;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button hobbyBtn;
        private Button colorBtn;
    }
}