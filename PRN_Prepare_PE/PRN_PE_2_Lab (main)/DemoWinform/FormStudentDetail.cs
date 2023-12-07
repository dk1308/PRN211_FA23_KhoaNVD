using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DAOs;
using Library.Models;

namespace FormStudentDetail
{
    public partial class FormStudentDetail : Form
    {
        public Student Student { get; set; }
        public Boolean IsInsert { get; set; }
        public FormStudentDetail()
        {
            InitializeComponent();
        }

        private void FormStudentDetail_Load(object sender, EventArgs e)
        {
            if (!IsInsert)
            {
                LoadForm();
                txtId.Enabled = false;
            }
            else txtId.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsInsert)
                {
                    StudentDAO.Instance.UpdateStudent(new Student
                    {
                        StudentId = int.Parse(txtId.Text),
                        StudentName = txtName.Text,
                        Address = txtAddress.Text,
                        Status = Boolean.Parse(txtStatus.Text)
                    });
                } else
                {
                    StudentDAO.Instance.InsertStudent(new Student
                    {
                        StudentName = txtName.Text,
                        Address = txtAddress.Text,
                        Status = Boolean.Parse(txtStatus.Text)
                    });
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void LoadForm()
        {
            txtId.Text = Student.StudentId.ToString();
            txtName.Text = Student.StudentName;
            txtAddress.Text = Student.Address;
            txtStatus.Text = Student.Status.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
