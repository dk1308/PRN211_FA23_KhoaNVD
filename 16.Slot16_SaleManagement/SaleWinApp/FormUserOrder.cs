using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class FormUserOrder : Form
    {
        public IOrderDetailRepository IOrderDetailRepository { get; set; }
        public IOrderRepository IOrderRepository { get; set; }
        public Member Member { get; set; }
        public FormUserOrder()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            try
            {
                IEnumerable<OrderDetail> orderDetails = IOrderDetailRepository.GetAllOrderDetailsByMemberId(Member.MemberId);
                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();
                txtOrderID.DataBindings.Add("Text", orderDetails, "OrderId");
                txtProductID.DataBindings.Add("Text", orderDetails, "ProductId");
                txtQuantity.DataBindings.Add("Text", orderDetails, "Quantity");
                txtDiscount.DataBindings.Add("Text", orderDetails, "Discount");

                // Get order 
                if (orderDetails == null) throw new Exception("List order details is empty");
                Orderr order = new OrderRepository().GetOrder(int.Parse(txtOrderID.Text));

                txtMemberID.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                dtRequiredDate.DataBindings.Clear();
                dtShippedDate.DataBindings.Clear();
                dtOrderDate.DataBindings.Clear();
                txtMemberID.DataBindings.Add("Text", order, "MemberId");
                txtFreight.DataBindings.Add("Text", order, "Freight");
                dtRequiredDate.DataBindings.Add("Value", order, "RequiredDate");
                dtShippedDate.DataBindings.Add("Value", order, "ShippedDate");
                dtOrderDate.DataBindings.Add("Value", order, "OrderDate");

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = orderDetails;

                if (orderDetails != null) btnDelete.Enabled = true;
                else btnDelete.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void dgvOrderDetailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListOrder_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text == "") throw new Exception("Can not delete orderID");
                Orderr order = new OrderRepository().GetOrder(int.Parse(txtOrderID.Text));

                txtMemberID.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                dtRequiredDate.DataBindings.Clear();
                dtShippedDate.DataBindings.Clear();
                dtOrderDate.DataBindings.Clear();
                txtMemberID.DataBindings.Add("Text", order, "MemberId");
                txtFreight.DataBindings.Add("Text", order, "Freight");
                dtRequiredDate.DataBindings.Add("Value", order, "RequiredDate");
                dtShippedDate.DataBindings.Add("Value", order, "ShippedDate");
                dtOrderDate.DataBindings.Add("Value", order, "OrderDate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                IOrderRepository.UpdateOrder(new Orderr
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    RequiredDate = dtRequiredDate.Value,
                    ShippedDate = dtShippedDate.Value,
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = dtOrderDate.Value
                });

                IOrderDetailRepository.UpdateOrderDetail(new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = int.Parse(txtDiscount.Text)
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
                int orderId = int.Parse(txtOrderID.Text);
                int productId = int.Parse(txtProductID.Text);
                IOrderDetailRepository.DeleteOrderDetail(orderId, productId);
                IEnumerable<OrderDetail> orderDetails = IOrderDetailRepository.GetAllOrderDetails();
                if (orderDetails.All(o => o.OrderId != orderId))
                    IOrderRepository.DeleteOrder(orderId);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IOrderRepository orderRepository = new OrderRepository();
            IProductRepository productRepository = new ProductRepository();
            try
            {
                DateTime startDate = dtStartDate.Value;
                DateTime endDate = dtEndDate.Value;

                IEnumerable<OrderDetail> list = IOrderDetailRepository.GetAllOrderDetailsByMemberId(Member.MemberId);

                list = list.Where(o => o.Orderr.OrderDate >= startDate && o.Orderr.OrderDate <= endDate)
                    .OrderByDescending(o => o.TotalMoney());

                if (list.IsNullOrEmpty()) throw new Exception("Not found orders!");

                // Calculate total money
                double totalMoney = 0;
                foreach (OrderDetail detail in list)
                {
                    totalMoney += detail.TotalMoney();
                }
                txtTotalMoney2.Text = totalMoney.ToString();

                LoadList(list.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadList(List<OrderDetail> list)
        {
            IEnumerable<OrderDetail> orderDetails = list;
            try
            {
                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();
                txtOrderID.DataBindings.Add("Text", orderDetails, "OrderId");
                txtProductID.DataBindings.Add("Text", orderDetails, "ProductId");
                txtQuantity.DataBindings.Add("Text", orderDetails, "Quantity");
                txtDiscount.DataBindings.Add("Text", orderDetails, "Discount");

                // Get order 
                if (orderDetails == null) throw new Exception("List order details is empty");
                Orderr order = new OrderRepository().GetOrder(int.Parse(txtOrderID.Text));

                txtMemberID.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                dtRequiredDate.DataBindings.Clear();
                dtShippedDate.DataBindings.Clear();
                dtOrderDate.DataBindings.Clear();
                txtMemberID.DataBindings.Add("Text", order, "MemberId");
                txtFreight.DataBindings.Add("Text", order, "Freight");
                dtRequiredDate.DataBindings.Add("Value", order, "RequiredDate");
                dtShippedDate.DataBindings.Add("Value", order, "ShippedDate");
                dtOrderDate.DataBindings.Add("Value", order, "OrderDate");

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = orderDetails;

                if (orderDetails != null) btnDelete.Enabled = true;
                else btnDelete.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
