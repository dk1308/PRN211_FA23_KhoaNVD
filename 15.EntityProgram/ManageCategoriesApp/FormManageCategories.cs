using ManageCategoriesApp.Data_Access;
using ManageCategoriesApp.Models;

namespace ManageCategoriesApp
{
    public partial class FormManageCategories : Form
    {
        public FormManageCategories()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category
            {
                CategoryName = txtCategoryName.Text
            };
            ManageCategories.Instance.InsertCategory(newCategory);
            LoadForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category
            {
                CategoryId = int.Parse(txtCategoryID.Text),
                CategoryName = txtCategoryName.Text
            };
            ManageCategories.Instance.UpdateCategory(newCategory);
            LoadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryID.Text);
            ManageCategories.Instance.DeleteCategory(categoryId);
            LoadForm();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormManageCategories_Load(object sender, EventArgs e) => LoadForm();
        public void LoadForm()
        {
            List<Category> categories = ManageCategories.Instance.GetCategories();

            // Clear data binding
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            // Add data binding to text box
            txtCategoryID.DataBindings.Add("Text", categories, "CategoryId");
            txtCategoryName.DataBindings.Add("Text", categories, "CategoryName");

            // Add to data grid view
            dgvCategories.DataSource = categories;
        }
    }
}