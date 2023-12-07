using Library.DAOs;
using Library.Models;

namespace FormEnrollmentDetail
{
    public partial class FormEnrollmentDetail : Form
    {
        public FormEnrollmentDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EnrollmentDAO.Instance.InsertEnrollment(new Enrollment
                {
                    StudentId = int.Parse(cboStudentId.Text),
                    CourseId = int.Parse(cboCourseId.Text),
                    DateUpdate = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEnrollmentDetail_Load(object sender, EventArgs e)
        {
            IEnumerable<Course> courses = CourseDAO.Instance.GetAllCourses();
            foreach(Course course in courses)
            {
                cboCourseId.Items.Add(course.CourseId);
            }
            IEnumerable<Student> students = StudentDAO.Instance.GetAllStudents();
            foreach (Student student in students)
            {
                cboStudentId.Items.Add(student.StudentId);
            }
        }
    }
}