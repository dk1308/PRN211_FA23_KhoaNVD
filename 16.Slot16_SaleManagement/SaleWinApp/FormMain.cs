using BusinessObject.Models;
using DataAccess.Repository;

namespace SaleWinApp
{
    public partial class FormMain : Form
    {
        public Member Member { get; set; }
        public Boolean IsAdmin { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(IsAdmin)
            {
                btnMemberPage.Enabled = false;
            } else btnAdminPage.Enabled = false;
        }

        private void btnAdminPage_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMemberPage_Click(object sender, EventArgs e)
        {
            FormMemberProfile formMemberProfile = new FormMemberProfile
            {
                IMemberRepository = new MemberRepository(),
                Member = Member
            };
            formMemberProfile.ShowDialog();
        }
    }
}