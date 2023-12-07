using Library.DAOs;
using Library.Models;
using Microsoft.IdentityModel.Tokens;

namespace FormEnrollment
{
    public partial class FormEnrollment : Form
    {
        public FormEnrollment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormEnrollmentDetail.FormEnrollmentDetail formEnrollmentDetail = new FormEnrollmentDetail.FormEnrollmentDetail();
                formEnrollmentDetail.ShowDialog();
                LoadForm(EnrollmentDAO.Instance.GetAllEnrollment());
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
                EnrollmentDAO.Instance.DeleteEnrollment(int.Parse(txtId.Text), int.Parse(txtCourseId.Text));
                LoadForm(EnrollmentDAO.Instance.GetAllEnrollment());
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

        private void FormEnrollment_Load(object sender, EventArgs e)
        {
            LoadForm(EnrollmentDAO.Instance.GetAllEnrollment());
        }

        private void LoadForm(List<Enrollment> enrollmentList)
        {
            try
            {
                IEnumerable<Enrollment> enrollments = enrollmentList;
                txtId.DataBindings.Clear();
                txtCourseId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                dtDateEnroll.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                
                txtId.DataBindings.Add("Text", enrollments, "StudentId");
                txtCourseId.DataBindings.Add("Text", enrollments, "CourseId");
                dtDateEnroll.DataBindings.Add("Value", enrollments, "DateUpdate");

                if (txtCourseId.Text.Length > 0)
                {
                    Course course = CourseDAO.Instance.GetCourse(int.Parse(txtCourseId.Text));
                    txtName.DataBindings.Add("Text", course, "CourseId");
                    txtStatus.DataBindings.Add("Text", course, "Status");
                }

                dgvEnrollment.DataSource = null;
                dgvEnrollment.DataSource = enrollments;

                if (enrollments.IsNullOrEmpty())
                {
                    ClearAll();
                    btnDelete.Enabled = false;
                }
                else btnDelete.Enabled = true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ClearAll()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCourseId.Text = string.Empty;
            txtStatus.Text = string.Empty;
            dtDateEnroll.Value = DateTime.Now;
        }
    }
}