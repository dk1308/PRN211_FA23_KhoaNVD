using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class FormMember : Form
    {
        public IMemberRepository IMemberRepository { get; set; }
        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IMemberRepository.InsertMember(new Member
                {
                    MemberId = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompany.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text
                });
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                IMemberRepository.UpdateMember(new Member
                {
                    MemberId = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompany.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text
                });
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update error");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                IMemberRepository.DeleteMember(int.Parse(txtID.Text));
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete error");
            }
        }

        private void ClearAllText()
        {
            txtID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void LoadForm()
        {
            IEnumerable<Member> members = IMemberRepository.GetAllMembers();

            txtID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompany.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtID.DataBindings.Add("Text", members, "MemberId");
            txtEmail.DataBindings.Add("Text", members, "Email");
            txtCompany.DataBindings.Add("Text", members, "CompanyName");
            txtCountry.DataBindings.Add("Text", members, "Country");
            txtCity.DataBindings.Add("Text", members, "City");
            txtPassword.DataBindings.Add("Text", members, "Password");

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = members;

            if (members.IsNullOrEmpty())
            {
                ClearAllText();
                btnDelete.Enabled = false;
            } else btnDelete.Enabled = true;
        }
    }
}
