using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class FormLogin : Form
    {
        const string adminEmail = "admin@fstore.com";
        const string adminPassword = "admin@@";

        private MemberRepository memberRepository;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            try
            {
                if (email.Equals(adminEmail) && password.Equals(adminPassword))
                {
                    FormMain formMain = new FormMain
                    {
                        IsAdmin = true
                    };
                    formMain.ShowDialog();
                }
                else
                {
                    Member member = new Member
                    {
                        Email = email,
                        Password = password
                    };
                    this.memberRepository = new MemberRepository();
                    if (memberRepository.Login(member) != null)
                    {
                        member = memberRepository.GetMemberByEmail(member.Email);
                        FormMain formMain = new FormMain
                        {
                            Member = member,
                            IsAdmin = false
                        };
                        formMain.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email or password is incorrect! ", "Login error");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
