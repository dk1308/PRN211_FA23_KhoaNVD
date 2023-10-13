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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (val1.Text == "" || val2.Text == "")
            {
                result.Text = "0";
                return;
            }

            int val1_Int = Convert.ToInt32(val1.Text);
            int val2_Int = Convert.ToInt32(val2.Text);
            result.Text = $"{val1_Int + val2_Int}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (val1.Text == "" || val2.Text == "")
            {
                result.Text = "0";
                return;
            }

            int val1_Int = Convert.ToInt32(val1.Text);
            int val2_Int = Convert.ToInt32(val2.Text);
            result.Text = $"{val1_Int - val2_Int}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (val1.Text == "" || val2.Text == "")
            {
                result.Text = "0";
                return;
            }

            int val1_Int = Convert.ToInt32(val1.Text);
            int val2_Int = Convert.ToInt32(val2.Text);
            result.Text = $"{val1_Int * val2_Int}";
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            val1.Clear();
            val2.Clear();
            result.Clear();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (val1.Text == "" || val2.Text == "" || val2.Text == "0")
            {
                result.Text = "0";
                return;
            }

            int val1_Int = Convert.ToInt32(val1.Text);
            int val2_Int = Convert.ToInt32(val2.Text);
            result.Text = $"{val1_Int % val2_Int}";
        }

        // allow only numeric input and 'delete'
        private void Val1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
        private void Val2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
