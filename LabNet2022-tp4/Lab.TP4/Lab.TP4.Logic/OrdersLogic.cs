using Lab.TP4.Data;
using Lab.TP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Logic
{
    public class OrdersLogic : BaseLogic<Orders>
    {
        public Orders SelectedOrder { get; set; }

        public OrdersLogic(IDataConnection context) : base(context)
        {
        }
        public override List<Orders> GetAll()
        {
            return _context.GetOrders().ToList();
        }
        public override void Add(Orders item)
        {
            throw new NotImplementedException();
        }

        public override Orders GetById(int orderId)
        {
            var order = _context.GetOrders().Find(orderId);

            if (order == null)
                throw new InvalidOperationException("No Order with such ID was found");
            return order;
        }

        public override void Remove(Orders order)
        {
            throw new NotImplementedException();
        }

        public override void Update(Orders item)
        {
            throw new NotImplementedException();
        }
    }
}
