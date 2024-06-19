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
    public partial class FormOrder : Form
    {
        public IOrderDetailRepository IOrderDetailRepository { get; set; }
        public IOrderRepository IOrderRepository { get; set; }
        public IProductRepository IProductRepository { get; set; }
        private IEnumerable<OrderDetail> orderDetails;
        public List<OrderDetail> OrderDetailsAsList { get; set; }
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            LoadForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IOrderRepository.InsertOrder(new Orderr
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    RequiredDate = dtRequiredDate.Value,
                    Freight = int.Parse(txtFreight.Text),
                    ShippedDate = dtShippedDate.Value,
                    OrderDate = DateTime.Now
                });

                foreach (OrderDetail detail in OrderDetailsAsList)
                {
                    IOrderDetailRepository.InsertOrderDetail(new OrderDetail
                    {
                        OrderId = detail.OrderId,
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        Discount = detail.Discount
/*                      Orderr = IOrderRepository.GetOrder(detail.OrderId),
                        Product = IProductRepository.GetProduct(detail.ProductId)*/
                    });
                }

                ClearAllText();
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert error");
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                orderDetails = orderDetails.Where(o => o.ProductId != int.Parse(txtProductID.Text)
                                                && o.OrderId != int.Parse(txtOrderID.Text));
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

        private void ClearAllText()
        {
            txtMemberID.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtFreight.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dtRequiredDate.Value = DateTime.Now;
            dtShippedDate.Value = DateTime.Now;
            txtTotalMoney.Text = string.Empty;
        }

        private void LoadForm()
        {
            IEnumerable<Product> products = IProductRepository.GetAllProducts();

            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add("Text", products, "ProductId");
            dgvProductList.DataSource = products;

            txtOrderID.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();

            orderDetails = OrderDetailsAsList;

            dgvOrderDetailList.DataSource = null;
            dgvOrderDetailList.DataSource = orderDetails;

            if (products.IsNullOrEmpty())
            {
                ClearAllText();
                btnDelete.Enabled = false;
            }
            else btnDelete.Enabled = true;
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtDiscount.Text) > 1 || double.Parse(txtDiscount.Text) < 0) throw new Exception("Discount must be in 0-1!");
                if (orderDetails.Any(o => o.OrderId != int.Parse(txtOrderID.Text))) throw new Exception("Cannot change orderId!");
                AutoInsertOrderDetail(OrderDetailsAsList, new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtDiscount.Text)
                });
                LoadForm();
                txtFreight_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            double totalMoney = 0;
            if (txtFreight.Text.Length > 0) totalMoney = int.Parse(txtFreight.Text);
            foreach (OrderDetail orderDetail in OrderDetailsAsList)
            {
                Product product = IProductRepository.GetProduct(orderDetail.ProductId);
                double moneyEachProduct = Convert.ToInt16(product.UnitPrice) * orderDetail.Quantity;
                totalMoney += moneyEachProduct - moneyEachProduct * double.Parse(txtDiscount.Text);
            }
            txtTotalMoney.Text = totalMoney.ToString();
        }

        private void AutoInsertOrderDetail(List<OrderDetail> orders, OrderDetail order)
        {
            foreach (OrderDetail item in orders)
            {
                if (item.OrderId == order.OrderId && item.ProductId == order.ProductId)
                {
                    orders.Remove(item);
                    orders.Add(order);
                    return;
                }
            }
            orders.Add(order);
        }

        private void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            FormListOrder formListOrder = new FormListOrder
            {
                IOrderDetailRepository = new OrderDetailRepository(),
                IOrderRepository = new OrderRepository()
            };
            formListOrder.ShowDialog();
        }
    }
}
