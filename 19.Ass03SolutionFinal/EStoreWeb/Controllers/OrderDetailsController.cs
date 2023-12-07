using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repository;
using Microsoft.CodeAnalysis;
using EStoreWeb.Models;
using Microsoft.IdentityModel.Tokens;
using Object;

namespace eStore.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly IOrderRepository orderRepo;
        private readonly IOrderDetailRepository orderDetailRepo;
        private readonly IProductRepository productRepo;
        private readonly IMemberRepository memberRepo;
        public OrderDetailsController()
        {
            orderRepo = new OrderRepository();
            orderDetailRepo = new OrderDetailRepository();
            productRepo = new ProductRepository();
            memberRepo = new MemberRepository();
        }

        // GET: OrderDetails?pageNumber=1&pageSize=1000
        public async Task<IActionResult> Index()
        {
            string account = HttpContext.Session.GetString("account");

            if (account.IsNullOrEmpty())
            {
                ViewData["Message"] = "Incorrect email and password";
                return RedirectToAction("Index", "Login");
            }

            return View(orderDetailRepo.GetAllOrderDetails());
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? orderId, int? productId)
        {
            if (orderId == null || productId == null || orderDetailRepo.GetAllOrderDetails() == null)
            {
                return NotFound();
            }

            var orderDetail = orderDetailRepo.GetAllOrderDetails()
                .FirstOrDefault(m => m.OrderId == orderId && m.ProductId == productId);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(orderRepo.GetAllOrders(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(productRepo.GetAllProducts(), "ProductId", "ProductName");
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,ProductId,UnitPrice,Quantity,Discount")] OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                orderDetailRepo.InsertOrderDetail(orderDetail);
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(orderRepo.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(productRepo.GetAllProducts(), "ProductId", "ProductName", orderDetail.ProductId);
            return View(orderDetail);
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? orderId, int? productId)
        {
            if (orderId == null || productId == null || orderDetailRepo.GetAllOrderDetails() == null)
            {
                return NotFound();
            }

            var orderDetail = orderDetailRepo.GetAllOrderDetails()
                .FirstOrDefault(m => m.OrderId == orderId && m.ProductId == productId);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,ProductId,UnitPrice,Quantity,Discount")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    orderDetailRepo.UpdateOrderDetail(orderDetail);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailExists(orderDetail.OrderId, orderDetail.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(orderRepo.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(productRepo.GetAllProducts(), "ProductId", "ProductName", orderDetail.ProductId);
            return View(orderDetail);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? orderId, int? productId)
        {
            if (orderId == null || productId == null || orderDetailRepo.GetAllOrderDetails() == null)
            {
                return NotFound();
            }

            var orderDetail = orderDetailRepo.GetAllOrderDetails()
                .FirstOrDefault(m => m.OrderId == orderId && m.ProductId == productId);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5&1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int orderId, int productId)
        {
            if (orderDetailRepo.GetAllOrderDetails() == null)
            {
                return Problem("Entity set 'SmdbContext.OrderDetails'  is null.");
            }
            var orderDetail = orderDetailRepo.GetOrderDetail(orderId, productId);
            if (orderDetail != null)
            {
                orderDetailRepo.DeleteOrderDetail(orderId, productId);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailExists(int orderId, int productId)
        {
            return (orderDetailRepo.GetAllOrderDetails()?.Any(e => e.OrderId == orderId && e.ProductId == productId)).GetValueOrDefault();
        }

        // GET: OrderDetails/Shopping
        public async Task<IActionResult> Shopping()
        {
            return productRepo.GetAllProducts() != null ?
                          View(productRepo.GetAllProducts()) :
                          Problem("Entity set 'SmdbContext.Products'  is null.");
        }

        // POST: OrderDetails/Shopping
        [HttpPost, ActionName("Shopping")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShoppingBuy()
        {
            // Get account
            string account = HttpContext.Session.GetString("account");
            if (account.IsNullOrEmpty())
            {
                ViewData["Message"] = "Incorrect email and password";
                return RedirectToAction("Index", "Login");
            }
            Member member = memberRepo.GetMemberByEmail(account);

            IEnumerable<Product> products = productRepo.GetAllProducts();
            List<double> quantityEachProduct = new List<double>();

            foreach (Product product in products)
            {
                string quantityAsString = Request.Form["number-buy-" + product.ProductId];
                if (quantityAsString == ""
                    || Convert.ToDouble(quantityAsString) < 0 )
                   // || Convert.ToDouble(quantityAsString) > product.UnitsInStock
                {
                    quantityEachProduct.Add(0);
                    products = products.Where(p => p.ProductId != product.ProductId);
                    continue;
                }
                quantityEachProduct.Add(Convert.ToDouble(quantityAsString));
                ViewData["Quantity" + product.ProductId] = Request.Form["number-buy-" + product.ProductId];
            }

            ViewBag.Products = products;

            ViewData["MemberId"] = member.MemberId;
            ViewData["MemberCity"] = member.City;
            ViewData["Freight"] = 10;

            // Calculate total money
            double totalMoney = 10;
            int idx = 0;
            foreach (var product in products)
            {
                if (quantityEachProduct[idx] == 0) idx++;
                totalMoney += Convert.ToDouble(product.UnitPrice) * quantityEachProduct[idx];
                idx++;
            };
            ViewData["TotalMoney"] = totalMoney;

            return View("ShoppingConfirm");
        }



        // POST: OrderDetails/ShoppingConfirm
        public async Task<IActionResult> ShoppingConfirm([Bind("MemberId", "RequiredDate", "ShippedDate", "Freight")] Orderr orderr, List<string> ProductId, List<string> ProductQuantity)
        {
            orderr.OrderDate = DateTime.Now;
            orderRepo.InsertOrder(orderr);

            List<Product> products = new List<Product>();
            foreach (string productId in ProductId)
            {
                products.Add(productRepo.GetProduct(Convert.ToInt16(productId)));
            }

            List<OrderDetail> orderAsList = new List<OrderDetail>();
            int idx = 0;
            foreach (var product in products)
            {
                if (Convert.ToInt16(ProductQuantity[idx]) <= 0)
                {
                    idx++;
                    continue;
                }

                product.UnitsInStock -= Convert.ToInt16(ProductQuantity[idx]);
                productRepo.UpdateProduct(product);

                orderAsList.Add(new OrderDetail
                {
                    OrderId = orderRepo.GetAllOrders().OrderBy(o => o.OrderId).Last().OrderId,
                    ProductId = product.ProductId,
                    UnitPrice = product.UnitPrice,
                    Quantity = Convert.ToInt16(ProductQuantity[idx]),
                    Discount = 0
                });
                idx++;
            }

            foreach (var order in orderAsList)
            {
                orderDetailRepo.InsertOrderDetail(order);
            }

            IEnumerable<OrderDetail> orderDetails = orderDetailRepo.GetAllOrderDetails().Where(o => o.OrderId == orderRepo.GetAllOrders().OrderBy(o => o.OrderId).Last().OrderId);

            // Get total money
            ViewData["totalMoney"] = Request.Form["totalMoney"];

            return View("ShoppingDetail", orderDetails);
        }
    }
}
