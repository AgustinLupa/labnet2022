using Lab.TP4.Entities;
using Lab.TP4.Logic;
using Lab.TPAPI.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab.TPAPI.UI.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        private readonly OrdersLogic _ordersLogic = LogicController.GetOrdersLogic();

        // GET: api/Orders
        [HttpGet]
        public List<OrderPresentation> Get()
        {
            var orders= _ordersLogic.GetAll();

            var result = orders.Select(o => new OrderPresentation
            {
                OrderID = o.OrderID,
                OrderDate = o.OrderDate,
                CustomerID = o.CustomerID,
                EmployeeID = o.EmployeeID,
                ShippedDate = o.ShippedDate,
                RequiredDate = o.RequiredDate
            }).ToList();

            return result;
        }

        // GET: api/Orders/5
        [HttpGet]
        public OrderPresentation Get(int id)
        {
            var order= _ordersLogic.GetById(id);

            var result = new OrderPresentation
            {
                CustomerID = order.CustomerID,
                OrderDate = order.OrderDate,
                OrderID = order.OrderID,
                EmployeeID= order.EmployeeID,
                ShippedDate= order.ShippedDate,
                RequiredDate= order.RequiredDate,
                Order_Details = order.Order_Details.Select(d => new OrderItemPresentation
                {
                    OrderID = d.OrderID,
                    ProductID = d.ProductID,
                    ProductName = d.Products.ProductName,
                    UnitPrice = d.UnitPrice,
                    Quantity = d.Quantity,
                    Discount = d.Discount
                }).ToList()
            };

            return result;
        }
    }
}
