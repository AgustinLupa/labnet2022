using Lab.TP4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Logic
{
    public static class LogicController
    {
        public static OrdersLogic GetOrdersLogic()
        {
            return new OrdersLogic(new NorthwindContext()); 
        }

        public static Order_DetailsLogic GetOrder_DetailsLogic()
        {
            return new Order_DetailsLogic(new NorthwindContext());
        }

        public static ProductsLogic GetProductsLogic()
        {
            return new ProductsLogic(new NorthwindContext());
        }
    }
}
