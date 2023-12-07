using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;

namespace SaleWinApp
{
    public partial class FormMemberProfile : Form
    {
        public IMemberRepository IMemberRepository { get; set; }
        public Member Member { get; set; }
        public FormMemberProfile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputs = { txtEmail.Text, txtCompanyName.Text, txtCountry.Text, txtCity.Text, txtPassword.Text };
                if (inputs.Any(s => s.Equals(""))) throw new Exception("Must fill all inputs");

                Member = new Member
                {
                    MemberId = Member.MemberId,
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                IMemberRepository.UpdateMember(Member);
                MessageBox.Show("Update profile successfully!","Update Profile");
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            FormUserOrder formUserOrder = new FormUserOrder
            {
                IOrderDetailRepository = new OrderDetailRepository(),
                IOrderRepository = new OrderRepository(),
                Member = this.Member
            };
            formUserOrder.ShowDialog();
        }

        private void FormMemberProfile_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            txtEmail.Text = Member.Email;
            txtCompanyName.Text = Member.CompanyName;
            txtCountry.Text = Member.Country;
            txtCity.Text = Member.City;
            txtPassword.Text = Member.Password;
        }
    }
}
