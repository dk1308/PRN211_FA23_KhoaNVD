using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Slot11_Lab
{
    public partial class FormHobby : Form
    {
        public FormHobby()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hobbyBtn_Click(object sender, EventArgs e)
        {
            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text + "\n";
            if (checkBox2.Checked) hobby += checkBox2.Text + "\n";
            if (checkBox3.Checked) hobby += checkBox3.Text + "\n";
            if (checkBox4.Checked) hobby += checkBox4.Text + "\n";
            if (checkBox5.Checked) hobby += checkBox5.Text + "\n";
            if (hobby.Length > 0)
            {
                MessageBox.Show($"Sở thích của bạn:\n {hobby}", "Kết quả");
            }
            else MessageBox.Show($"Bạn không có sở thích nào!", "Kết quả");
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            string color = "";
            if (radioButton1.Checked) color += radioButton1.Text + "\n";
            if (radioButton2.Checked) color += radioButton2.Text + "\n";
            if (radioButton3.Checked) color += radioButton3.Text + "\n";
            if (radioButton5.Checked) color += radioButton5.Text + "\n";
            if (radioButton6.Checked) color += radioButton6.Text + "\n";
            if (color.Length > 0)
            {
                MessageBox.Show($"Màu bạn thích:\n {color}", "Kết quả");
            }
            else MessageBox.Show($"Bạn không có màu yêu thích nào!", "Kết quả");
        }

        
    }
}
