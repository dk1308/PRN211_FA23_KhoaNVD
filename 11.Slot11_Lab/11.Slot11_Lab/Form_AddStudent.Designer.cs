namespace _11.Slot11_Lab
{
    partial class Form_AddStudent
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
            label1 = new Label();
            nameTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mathTxt = new TextBox();
            physTxt = new TextBox();
            chemTxt = new TextBox();
            addBtn = new Button();
            showBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 68);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(175, 68);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(206, 27);
            nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 131);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Điểm toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 197);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Điểm lý";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 260);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Điểm hóa";
            // 
            // mathTxt
            // 
            mathTxt.Location = new Point(175, 131);
            mathTxt.Name = "mathTxt";
            mathTxt.Size = new Size(206, 27);
            mathTxt.TabIndex = 5;
            // 
            // physTxt
            // 
            physTxt.Location = new Point(175, 194);
            physTxt.Name = "physTxt";
            physTxt.Size = new Size(206, 27);
            physTxt.TabIndex = 6;
            // 
            // chemTxt
            // 
            chemTxt.Location = new Point(175, 257);
            chemTxt.Name = "chemTxt";
            chemTxt.Size = new Size(206, 27);
            chemTxt.TabIndex = 7;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(84, 323);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(116, 42);
            addBtn.TabIndex = 8;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(256, 323);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(111, 42);
            showBtn.TabIndex = 9;
            showBtn.Text = "Hiển thị";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // Form_AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 425);
            Controls.Add(showBtn);
            Controls.Add(addBtn);
            Controls.Add(chemTxt);
            Controls.Add(physTxt);
            Controls.Add(mathTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTxt);
            Controls.Add(label1);
            Name = "Form_AddStudent";
            Text = "Form_AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mathTxt;
        private TextBox physTxt;
        private TextBox chemTxt;
        private Button addBtn;
        private Button showBtn;
    }
}