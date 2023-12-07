using Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        int WhoLogin {  get; set; }
        UsersDao usersDao = new UsersDao();

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Users user = usersDao.findUsersByUserName(TxtUserName.Text);
            if (user != null)
            {
                if (user.Password.Equals(TxtPassword.Text))
                {
                    MessageBox.Show("Login Success");
                    WhoLogin = user.UserId;
                    frm_NewsApp OpenNewsApp = new frm_NewsApp();
                    OpenNewsApp.WhoLogin = WhoLogin;
                    OpenNewsApp.Show();
                }
                else MessageBox.Show("Password not correct");
            }
            else MessageBox.Show("Username not correct ");
        }
    }
}
