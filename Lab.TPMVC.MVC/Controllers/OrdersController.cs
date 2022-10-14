using Lab.TP4.Entities;
using Lab.TP4.Logic;
using Lab.TPMVC.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.TPMVC.MVC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrdersLogic _ordersLogic = LogicController.GetOrdersLogic();
        private readonly Order_DetailsLogic _detailsLogic = LogicController.GetOrder_DetailsLogic();
        private readonly ProductsLogic _productsLogic = LogicController.GetProductsLogic();
        private static int s_selectedOrderId;

        // GET: Orders
        public ActionResult Index()
        {
            ViewBag.Message = "Orders List.";

            List<OrderPresentation> orders = _ordersLogic.GetAll().Select(o => new OrderPresentation
            {
                OrderID = o.OrderID,
                CustomerID = o.CustomerID,
                EmployeeID = o.EmployeeID,
                OrderDate = o.OrderDate,
                RequiredDate = o.RequiredDate,
                ShippedDate = o.ShippedDate
            }).ToList();

            return View(orders);
        }

        public ActionResult ViewDetails(int orderId)
        {
            var order = _ordersLogic.GetById(orderId);
            s_selectedOrderId = orderId;

            List<OrderItemPresentation> orderItems = order.Order_Details.Select(d => new OrderItemPresentation
            {
                OrderID=d.OrderID,
                ProductID = d.ProductID,
                ProductName = d.Products.ProductName,
                UnitPrice = d.UnitPrice,
                Quantity = d.Quantity,
                Discount = d.Discount
            }).ToList();

            return View(orderItems);
        }

        public ActionResult DeleteItem(int productId)
        {
            Order_Details item = new Order_Details
            {
                OrderID = s_selectedOrderId,
                ProductID = productId
            };

            try
            {
                _detailsLogic.Remove(item);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }

            return RedirectToAction("ViewDetails", new {orderId = s_selectedOrderId});
        }

        public ActionResult AddOrEditItem(int? productId = null)
        {
            var set = new ItemWithProductsContainer
            {
                products = _productsLogic.GetAll().Select(p => new ProductPresentation
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice
                }).ToList()
            };

            if (productId != null)
            {
                var order = _ordersLogic.GetById(s_selectedOrderId);
                var order_details = order.Order_Details.FirstOrDefault(d => d.ProductID == productId);
                set.item = new OrderItemPresentation
                {
                    OrderID = order.OrderID,
                    ProductName = order_details.Products.ProductName,
                    ProductID = order_details.ProductID,
                    UnitPrice = order_details.UnitPrice,
                    Quantity = order_details.Quantity,
                    Discount = order_details.Discount
                };
            }

            return View(set);
        }

        [HttpPost]
        public ActionResult AddItem(ItemWithProductsContainer order)
        {
            try
            {
                var item = new Order_Details
                {
                    OrderID = s_selectedOrderId,
                    ProductID = order.item.ProductID,
                    UnitPrice = order.item.UnitPrice,
                    Quantity = order.item.Quantity,
                    Discount = order.item.Discount
                };

                _detailsLogic.Add(item);

                return RedirectToAction("ViewDetails", new { orderId = s_selectedOrderId });
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }

        [HttpPost]
        public ActionResult EditItem(ItemWithProductsContainer order)
        {
            try
            {
                var item = new Order_Details
                {
                    OrderID = s_selectedOrderId,
                    ProductID = order.item.ProductID,
                    UnitPrice = order.item.UnitPrice,
                    Quantity = order.item.Quantity,
                    Discount = order.item.Discount
                };

                _detailsLogic.Update(item);

                return RedirectToAction("ViewDetails", new { orderId = s_selectedOrderId });
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }
    }
}