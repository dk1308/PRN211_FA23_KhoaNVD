using FormStudentDetail;
using Library.DAOs;
using Library.Models;
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

namespace FormStudent
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            LoadForm(StudentDAO.Instance.GetAllStudents());
        }

        private void LoadForm(List<Student> studentList)
        {
            IEnumerable<Student> students = studentList;
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtStatus.DataBindings.Clear();

            txtId.DataBindings.Add("Text", students, "StudentId");
            txtName.DataBindings.Add("Text", students, "StudentName");
            txtAddress.DataBindings.Add("Text", students, "Address");
            txtStatus.DataBindings.Add("Text", students, "Status");

            dgvStudent.DataSource = null;
            dgvStudent.DataSource = students;

            if (students.IsNullOrEmpty())
            {
                ClearAll();
                btnDelete.Enabled = false;
            }
            else btnDelete.Enabled = true;
        }

        private void ClearAll()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string value = txtSearch.Text;
                if (string.IsNullOrEmpty(value)) throw new Exception("Must input search value before searching!");
                IEnumerable<Student> students = StudentDAO.Instance.GetAllStudents();
                LoadForm(students.Where(s => s.StudentName.Contains(value)).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormStudentDetail.FormStudentDetail formStudentDetail = new FormStudentDetail.FormStudentDetail
                {
                    IsInsert = true
                };
                formStudentDetail.ShowDialog();
                LoadForm(StudentDAO.Instance.GetAllStudents());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormStudentDetail.FormStudentDetail formStudentDetail = new FormStudentDetail.FormStudentDetail
                {
                    Student = new Student
                    {
                        StudentId = int.Parse(txtId.Text),
                        StudentName = txtName.Text,
                        Address = txtAddress.Text,
                        Status = Boolean.Parse(txtStatus.Text)
                    },
                    IsInsert = false
                };
                formStudentDetail.ShowDialog();
                LoadForm(StudentDAO.Instance.GetAllStudents());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDAO.Instance.DeleteStudent(int.Parse(txtId.Text));
                LoadForm(StudentDAO.Instance.GetAllStudents());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
