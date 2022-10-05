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
            var query = customerLogic.FirstCustomer();           
            lbList.Items.Add(query.ContactName);
        }

        private void btnExcer2_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            var query = productLogic.GetProductOutOfStock();
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName);
            }
        }

        private void btnExcer3_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Products> query = productLogic.GetProducts();
            foreach (Products products in query)
            {
                lbList.Items.Add(products.ProductName);
            }
        }

        private void btnExcer4_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Customers> query = customerLogic.GetCustomerRegion();
            foreach (Customers customers in query)
            {
                lbList.Items.Add(customers.CompanyName);
            }
        }

        private void btnExcer5_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Products> query = productLogic.GetProductsByID(789);
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
            var query = customerLogic.GetOrderInCustomer();
            foreach (var item in query)
            {
                lbList.Items.Add(item.ToString());
            }
        }

        private void btnExcer8_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Customers> query = customerLogic.GetCustomersRegion("WA");           
            foreach (var item in query)
            {
                lbList.Items.Add(item.CompanyName);
            }
        }

        private void btnExcer9_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();

            IEnumerable<Products> query = productLogic.GetProductOrderlyAsc();
            foreach (var item in query)
            {
                lbList.Items.Add(item.ProductName);
            }
        }

        private void btnExcer10_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            IEnumerable<Products> query = productLogic.GetProductUnitPriceOrderlyDesc();
            foreach (var item in query)
            {
                lbList.Items.Add($"Nombre: {item.ProductName}, Unidades en stock: {item.UnitsInStock}");
            }
        }
    }
}
