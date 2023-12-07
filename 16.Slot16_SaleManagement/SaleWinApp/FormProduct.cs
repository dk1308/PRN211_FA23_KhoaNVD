using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;

namespace SaleWinApp
{
    public partial class FormProduct : Form
    {
        public IProductRepository IProductRepository { get; set; }
        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IProductRepository.InsertProduct(new Product
                {
                    ProductId = int.Parse(txtID.Text),
                    Weight = txtWeight.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = int.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                });
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                IProductRepository.UpdateProduct(new Product
                {
                    ProductId = int.Parse(txtID.Text),
                    Weight = txtWeight.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = int.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                });
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                IProductRepository.DeleteProduct(int.Parse(txtID.Text));
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void ClearAllText()
        {
            txtID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void LoadForm()
        {
            IEnumerable<Product> products = IProductRepository.GetAllProducts();

            txtID.DataBindings.Clear();
            txtCategoryID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();
            txtWeight.DataBindings.Clear();

            txtID.DataBindings.Add("Text", products, "ProductId");
            txtCategoryID.DataBindings.Add("Text", products, "CategoryId");
            txtProductName.DataBindings.Add("Text", products, "ProductName");
            txtUnitPrice.DataBindings.Add("Text", products, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", products, "UnitsInStock");
            txtWeight.DataBindings.Add("Text", products, "Weight");

            dgvProductList.DataSource = products;

            if (products.IsNullOrEmpty())
            {
                ClearAllText();
                btnDelete.Enabled = false;
            }
            else btnDelete.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Product> products = IProductRepository.GetAllProducts();

                string criteria = cboCriteria.Text;
                string value = txtValue.Text;


                if (criteria.Equals("All"))
                {
                    LoadList(products.ToList());
                    return;
                }
                else if (value.IsNullOrEmpty() || criteria.IsNullOrEmpty()) throw new Exception("Must input Criteria and Value fields!");

                switch (criteria)
                {
                    case "ProductID":
                        products = products.Where(p => p.ProductId == int.Parse(value));
                        break;
                    case "ProductName":
                        products = products.Where(p => p.ProductName.Contains(value));
                        break;
                    case "UnitPrice":
                        products = products.Where(p => p.UnitPrice == int.Parse(value));
                        break;
                    case "UnitInStock":
                        products = products.Where(p => p.UnitsInStock == int.Parse(value));
                        break;
                }
                LoadList(products.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void LoadList(List<Product> products)
        {
            txtID.DataBindings.Clear();
            txtCategoryID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();
            txtWeight.DataBindings.Clear();

            txtID.DataBindings.Add("Text", products, "ProductId");
            txtCategoryID.DataBindings.Add("Text", products, "CategoryId");
            txtProductName.DataBindings.Add("Text", products, "ProductName");
            txtUnitPrice.DataBindings.Add("Text", products, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", products, "UnitsInStock");
            txtWeight.DataBindings.Add("Text", products, "Weight");

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = products;

            if (products.IsNullOrEmpty())
            {
                ClearAllText();
                btnDelete.Enabled = false;
            }
            else btnDelete.Enabled = true;
        }
    }
}
