using Lab.TP4.Data;
using Lab.TP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Logic
{
    public class Order_DetailsLogic : BaseLogic<Order_Details>
    {
        public Order_DetailsLogic(IDataConnection context) : base(context)
        {
        }

        public override List<Order_Details> GetAll()
        {
            return _context.GetOrder_Details().ToList();
        }
        public override void Update(Order_Details orderItem)
        {
            var allItems = _context.GetOrder_Details();
            var itemToUpdate = allItems.FirstOrDefault(i => (i.OrderID == orderItem.OrderID) && (i.ProductID == orderItem.ProductID));

            itemToUpdate.UnitPrice = orderItem.UnitPrice;
            itemToUpdate.Quantity = orderItem.Quantity;
            itemToUpdate.Discount = orderItem.Discount;
            _context.SaveChanges();
        }
        public override Order_Details GetById(int orderId)
        {
            throw new NotImplementedException("This method is not implemented");
        }

        public override void Add(Order_Details item)
        {
            var allItems = _context.GetOrder_Details();
            allItems.Add(item);
            _context.SaveChanges();
        }

        public override void Remove(Order_Details orderItem)
        {
            //_context.GetOrder_Details().Remove(orderItem);
            //_context.SaveChanges();

            var allItems = _context.GetOrder_Details();
            var itemToRemove = allItems.FirstOrDefault(i => (i.OrderID == orderItem.OrderID) && (i.ProductID == orderItem.ProductID) );

            allItems.Remove(itemToRemove);
            _context.SaveChanges();
        }
    }
}
