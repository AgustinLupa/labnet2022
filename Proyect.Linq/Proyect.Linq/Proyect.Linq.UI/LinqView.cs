using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyect.Linq.Logic;
using Proyect.Linq.Entities;

namespace Proyect.Linq.UI
{
    public partial class LinqView : Form
    {
        CustomerLogic customerLogic = new CustomerLogic();
        ProductLogic productLogic = new ProductLogic();
        OrdersLogic OrdersLogic = new OrdersLogic();
        public LinqView()
        {
            InitializeComponent();
        }

        private void btnExcer1_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Customers> query = customerLogic.GetAll().Take(1);           
            foreach (Customers customer in query)
            {
                lbList.Items.Add(customer.ContactName);
            }
        }

        private void btnExcer2_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Products> query = productLogic.GetAll().Where(p=> p.UnitsInStock < 1);
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName);
            }
        }

        private void btnExcer3_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Products> query = productLogic.GetAll().Where(p => p.UnitsInStock > 0 
            && p.UnitPrice > 3);
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName);
            }
        }

        private void btnExcer4_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Customers> query = customerLogic.GetAll().Where(c => c.Region == "WA");
            foreach (Customers customers in query)
            {
                lbList.Items.Add(customers.CompanyName);
            }
        }

        private void btnExcer5_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Products> query = productLogic.GetAll().Where(p => p.ProductID == 789);
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName);
            }
        }

        private void btnExcer6_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            var query = productLogic.GetAll();
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName.ToUpper());
            }
            lbList.Items.Add("\n------------------------------------------------------------\n");
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName.ToLower());
            }
        }

        private void btnExcer7_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            var queryOrder = OrdersLogic.GetAll();
            var queryCustomer = customerLogic.GetAll();

            var query = from order in queryOrder
                        join customers in queryCustomer
                        on new { order.CustomerID }
                            equals new { customers.CustomerID }
                        where customers.Region == "WA" && order.OrderDate > DateTime.Parse("1997-01-01")
                        select new
                        {
                            order.OrderID,
                            customers.ContactName,
                            customers.Region,
                            order.OrderDate
                        };
            foreach (var item in query)
            {
                lbList.Items.Add($"Order: {item.OrderID}, for: {item.ContactName}, region: {item.Region}, Fecha: {item.OrderDate}");
            }
        }

        private void btnExcer8_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            var queryCustomer = customerLogic.GetAll();
            IEnumerable<Customers> query = from customers in queryCustomer
                                           where (customers.Region == "WA")
                                           select customers;           
            foreach (var item in query)
            {
                lbList.Items.Add(item.CompanyName);
            }
        }

        private void btnExcer9_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            var queryProduct = productLogic.GetAll();
            IEnumerable<Products> query = from products in queryProduct
                                          orderby products.ProductName ascending
                                          select products;
            foreach (var item in query)
            {
                lbList.Items.Add(item.ProductName);
            }
        }

        private void btnExcer10_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            var queryProduct = productLogic.GetAll();
            IEnumerable<Products> query = from products in queryProduct
                                          orderby products.UnitsInStock descending
                                          select products;
            foreach (var item in query)
            {
                lbList.Items.Add($"Nombre: {item.ProductName}, Unidades en stock: {item.UnitsInStock}");
            }
        }
    }
}
