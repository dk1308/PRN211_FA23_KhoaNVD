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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            formStudent.ShowDialog();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            FormEnrollment.FormEnrollment formEnrollment = new FormEnrollment.FormEnrollment();
            formEnrollment.ShowDialog();
        }
    }
}
