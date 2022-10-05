using Proyect.Linq.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.Linq.Logic
{
    public class CustomerLogic : BaseLogic
    {        
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers FirstCustomer()
        {
            return context.Customers.First();
        }

        public List<Customers> GetCustomerRegion()
        {
            return context.Customers.Where(c => c.Region == "WA").ToList();
        }

        public List<DtoCustomersOrders> GetOrderInCustomer()
        {
            List<DtoCustomersOrders> auxCustomerOrder = new List<DtoCustomersOrders>();
            DateTime Date = DateTime.Parse("1997-01-01");            
            var query = from orders in context.Orders
                        join customers in context.Customers
                        on new { orders.CustomerID }
                            equals new { customers.CustomerID }
                        where customers.Region == "WA" && orders.OrderDate > Date
                        select new
                        {
                            orders.OrderID,
                            customers.ContactName,
                            customers.Region,
                            orders.OrderDate
                        };
            foreach (var item in query)
            {
                DtoCustomersOrders dtoCustomersOrders = new DtoCustomersOrders();
                dtoCustomersOrders.OrderID = item.OrderID;
                dtoCustomersOrders.ContactName = item.ContactName;
                dtoCustomersOrders.Region = item.Region;
                dtoCustomersOrders.OrderDate = Convert.ToDateTime(item.OrderDate);
                auxCustomerOrder.Add(dtoCustomersOrders);
            }
            return auxCustomerOrder;
        }

        public List<Customers> GetCustomersRegion(string region)
        {
            List<Customers> auxCustomers = new List<Customers>();
            var query = from customers in context.Customers
                        where (customers.Region == region)
                        select customers;
            foreach (var item in query)
            {
                auxCustomers.Add(item);
            }
            return auxCustomers;
        }        
    }
}
