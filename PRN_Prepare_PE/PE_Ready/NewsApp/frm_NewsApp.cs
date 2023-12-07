using Data_Access;

namespace NewsApp
{
    public partial class frm_NewsApp : Form
    {
        public frm_NewsApp()
        {
            InitializeComponent();
        }

        public NewsDao newsDao = new NewsDao();
        public int WhoLogin { get; set; }
        public int NewsId { get; set; }
        private void LoadNews()
        {
            var news = newsDao.GetAllNews();
            TxtNewsId.DataBindings.Clear();
            //-----------------------------------------
            TxtNewsId.DataBindings.Add("Text", news, "Id");
            Dgv_News.DataSource = news;
            //-----------------------------------------

        }



        private void Dgv_News_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {


            try
            {
                int newId;
                if (string.IsNullOrWhiteSpace(TxtNewsId.Text)) newId = -1; else newId = int.Parse(TxtNewsId.Text);
                NewsDetail OpenNewDetail = new NewsDetail();
                OpenNewDetail.NewsId = newId;
                OpenNewDetail.WhoLogin = WhoLogin;
                OpenNewDetail.InsertOrUpdate = true;
                OpenNewDetail.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int newId;
                if (string.IsNullOrWhiteSpace(TxtNewsId.Text)) newId = -1; else newId = int.Parse(TxtNewsId.Text);
                NewsDetail OpenNewDetail = new NewsDetail();
                OpenNewDetail.NewsId = newId;
                OpenNewDetail.WhoLogin = WhoLogin;
                OpenNewDetail.InsertOrUpdate = false;
                OpenNewDetail.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            NewsDao.Instance.DeleteNews(NewsDao.Instance.findNewsById(int.Parse(TxtNewsId.Text)));
            MessageBox.Show("Delete Success !");
            LoadNews();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_NewsApp_Load(object sender, EventArgs e)
        {
            LoadNews();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadNews();
        }
    }
}