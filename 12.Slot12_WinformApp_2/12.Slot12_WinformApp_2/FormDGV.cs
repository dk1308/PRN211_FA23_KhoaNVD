namespace _12.Slot12_WinformApp_2
{
    public partial class FormDGV : Form
    {
        public FormDGV()
        {
            InitializeComponent();
        }

        private void FormDGVLoad(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1, Name = "Dang Khoa", Score = 10},
                new Student{Id=2, Name = "Luong Tai", Score = 10},
                new Student{Id=3, Name = "Viet Hung", Score = 10},
                new Student{Id=3, Name = "Huy Hoang", Score = 10}
            };
            dgvStudentList.DataSource = students;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}