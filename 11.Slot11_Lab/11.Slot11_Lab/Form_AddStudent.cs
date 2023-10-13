using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Slot11_Lab
{
    public partial class Form_AddStudent : Form
    {
        List<Student> students = new List<Student>();
        public Form_AddStudent()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || mathTxt.Text == "" || physTxt.Text == "" || chemTxt.Text == "")
            {
                MessageBox.Show("Không được để trống", "Kết quả thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(Regex.IsMatch(mathTxt.Text, @"^[0-9]*(?:\.[0-9]*)?$")  && Regex.IsMatch(physTxt.Text, @"^[0-9]*(?:\.[0-9]*)?$") 
                && Regex.IsMatch(chemTxt.Text, @"^[0-9]*(?:\.[0-9]*)?$")))
            {
                MessageBox.Show("Điểm phải là số", "Kết quả thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float mathMark = float.Parse(mathTxt.Text);
            float physMark = float.Parse(physTxt.Text);
            float chemMark = float.Parse(chemTxt.Text);
            if (mathMark>10 || mathMark<0 || physMark>10 || physMark<0 || chemMark>10 || chemMark<0)
            {
                MessageBox.Show("Điểm không hợp lệ", "Kết quả thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student std = new Student(nameTxt.Text, mathMark, physMark, chemMark);
            students.Add(std);
            MessageBox.Show("Thêm sinh viên thành công!", "Kết quả thêm sinh viên");
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            string result = "";
            if(students.Count > 0) {
                int count = 0;
                foreach(Student student in students)
                {
                    result += $"Sinh viên {++count}: {student}\n";
                }
                MessageBox.Show(result, "Danh sách sinh viên");
            }else MessageBox.Show("Không có sinh viên nào!","Danh sách sinh viên");
        }
    }
}
