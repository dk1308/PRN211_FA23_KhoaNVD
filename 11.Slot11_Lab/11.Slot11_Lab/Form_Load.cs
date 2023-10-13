namespace lab5
{
    public partial class Form_Load : Form
    {
        public Form_Load()
        {
            InitializeComponent();
        }
        private void fullNamelb_Click(object sender, EventArgs e)
        {

        }
        private void fullName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            string fn = fullName.Text;
            MessageBox.Show(fn, "Full Name");
        }
        
        // Handle before form open
        private void FormLoad_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want open this program?", "Ask the user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) 
                Dispose(); 
        }

        // Handle event press Alt + H
        private void KeyDown_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Alt | Keys.H))
            {
                fullName.Text = "Hello FPT University";
            }
        }
        
        // Handle event mouse down
        private void FormLoad_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left Mouse");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right Mouse");
            }
            if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Middle Mouse");
            }
        }

        // Handle event click exit btn
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "Ask the user", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                this.Close();
        }
    }
}
