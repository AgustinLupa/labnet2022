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
    [RoutePrefix("api/Item")]
    public class ItemController : ApiController
    {
        private readonly OrdersLogic _ordersLogic = LogicController.GetOrdersLogic();
        private readonly Order_DetailsLogic _detailsLogic = LogicController.GetOrder_DetailsLogic();       

        public ItemController()
        {
        }

        // GET: api/Item?orderId=10248
        [HttpGet]
        public List<OrderItemPresentation> Get(int orderId)
        {
            var order = _ordersLogic.GetById(orderId);

            var result = order.Order_Details.Select(d => new OrderItemPresentation
            {
                OrderID = d.OrderID,
                ProductID = d.ProductID,
                ProductName = d.Products.ProductName,
                UnitPrice = d.UnitPrice,
                Quantity = d.Quantity,
                Discount = d.Discount
            }).ToList();

            return result;
        }

        // GET: api/Item?orderId=10248&productId=10
        [HttpGet]
        public OrderItemPresentation Get(int orderId, int productId)
        {
            var order = _ordersLogic.GetById(orderId);

            var item = order.Order_Details.FirstOrDefault(d => d.ProductID == productId);

            var result = new OrderItemPresentation
            {
                OrderID = item.OrderID,
                ProductID = item.ProductID,
                ProductName = item.Products.ProductName,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity,
                Discount = item.Discount
            };

            return result;
        }

        // POST: api/Item
        [HttpPost]
        public void Post(OrderItemPresentation item)
        {
            var details = new Order_Details()
            {
                OrderID=item.OrderID,
                ProductID=item.ProductID,
                UnitPrice=item.UnitPrice,
                Quantity=item.Quantity,
                Discount=item.Discount
            };
            try
            {
                _detailsLogic.Add(details);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Item
        [HttpPut]
        public void Put(OrderItemPresentation item)
        {
            var details = new Order_Details()
            {
                OrderID = item.OrderID,
                ProductID = item.ProductID,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity,
                Discount = item.Discount
            };
            try
            {
                _detailsLogic.Update(details);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/Item?orderId={orderId}&productId={productId}
        [HttpDelete]
        public void Delete(int orderId, int productId)
        {
            var toDelete = new Order_Details()
            {
                OrderID = orderId,
                ProductID = productId
            };

            try
            {
                _detailsLogic.Remove(toDelete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
