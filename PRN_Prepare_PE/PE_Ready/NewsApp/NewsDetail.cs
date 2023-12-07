using Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp
{
    public partial class NewsDetail : Form
    {
        public NewsDetail()
        {
            InitializeComponent();
        }
        public int NewsId { get; set; }
        public int WhoLogin { get; set; }
        public bool InsertOrUpdate { get; set; }
        public NewsDao newsDao = new NewsDao();
        public CategoryDao categoryDao = new CategoryDao();
        private void LoadNewsDetail()
        {
            List<string> status = new List<string>
            {
                "Private",
                "Public"
            };
            if (InsertOrUpdate == false) //update
            {
                var category = categoryDao.GetAllCategories();

                News news = newsDao.findNewsById(NewsId);
                BtnInsert.Visible = false;
                TxtDateUpdate.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtTitles.DataBindings.Clear();
                //-----------------------------------------
                TxtDateUpdate.DataBindings.Add("Text", news, "DateUpdate");
                txtDescription.DataBindings.Add("Text", news, "Description");
                txtTitles.DataBindings.Add("Text", news, "Titles");
                CbCategory.DataSource = category;
                CbCategory.DisplayMember = "Name";
                CbCategory.SelectedIndex = CbCategory.FindStringExact(CategoryDao.Instance.findCategoryById(news.CatetoryID).Name);  
                CbStatus.DataSource = status;
                if (news.Status == true) CbStatus.SelectedIndex = 1;
                else CbStatus.SelectedIndex = 0;
            }
            else
            { //insert
                List<Categories> category = categoryDao.GetAllCategories();
                BtnUpdate.Visible = false;
                //-----------------------------------------
                TxtDateUpdate.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtTitles.DataBindings.Clear();
                TxtDateUpdate.Text = DateTime.Now.ToString();
                //-----------------------------------------
                CbCategory.ValueMember = null;
                CbCategory.DataSource = category;
                CbCategory.DisplayMember = "Name";
                CbStatus.DataSource = status;
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtDateUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewsDetail_Load(object sender, EventArgs e)
        {
            LoadNewsDetail();

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            bool Status = false;
            if (CbStatus.SelectedItem.ToString().Equals("Public")) Status = true;
            var SelectedCate = (Categories)CbCategory.SelectedItem;
            int CategoryId = SelectedCate.CatetoryID;
            News news = new News()
            {
                DateUpdate = DateTime.Parse(TxtDateUpdate.Text),
                Description = txtDescription.Text,
                Titles = txtTitles.Text,
                UserId = WhoLogin,
                Status = Status,
                CatetoryID = CategoryId
            };
            NewsDao.Instance.InsertNews(news);
            MessageBox.Show("Insert Successfully");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            bool Status = false;
            if (CbStatus.SelectedItem.ToString().Equals("Public")) Status = true;
            var SelectedCate = (Categories)CbCategory.SelectedItem;
            int CategoryId = SelectedCate.CatetoryID;

            News news = NewsDao.Instance.findNewsById(NewsId);
            news.DateUpdate = DateTime.Parse(TxtDateUpdate.Text);
            news.Description = txtDescription.Text;
            news.Titles = txtTitles.Text;
            news.CatetoryID = CategoryId; 
            news.Status = Status;

            NewsDao.Instance.UpdateNews(news);
            MessageBox.Show("Update Successfully");
        }
    }
}
