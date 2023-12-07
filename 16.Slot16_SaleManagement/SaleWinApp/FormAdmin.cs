using DataAccess.Repository;
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
namespace SaleWinApp
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember
            {
                IMemberRepository = new MemberRepository()
            };
            formMember.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct
            {
                IProductRepository = new ProductRepository()
            };
            formProduct.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder
            {
                IOrderRepository = new OrderRepository(),
                IOrderDetailRepository = new OrderDetailRepository(),
                IProductRepository= new ProductRepository(),
                OrderDetailsAsList = new List<OrderDetail>()
            };
            formOrder.ShowDialog();
        }

        private void btnReportStatistic_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
