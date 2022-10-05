using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Proyect.Linq.Data;
using Proyect.Linq.Entities;

namespace Proyect.Linq.Logic
{
    public class ProductLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<Products> GetProductOutOfStock()
        {
            return context.Products.Where(p=> p.UnitsInStock < 1).ToList();
        }

        public List<Products> GetProducts()
        {
            return context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
        }

        public List<Products> GetProductsByID(int id)
        {
            return context.Products.Where(p => p.ProductID == id).ToList();
        }

        public List<Products> GetProductOrderlyAsc()
        {
            List<Products> products = new List<Products>();
            var query =from Products in context.Products
            orderby Products.ProductName ascending
            select Products;
            foreach (var item in query)
            {
                products.Add(item);
            }
            return products;
        }

        public List<Products> GetProductUnitPriceOrderlyDesc()
        {
            List<Products> products = new List<Products>();
            var query = from Products in context.Products
                        orderby Products.UnitsInStock descending
                        select Products;
            foreach (var item in query)
            {
                products.Add(item);
            }
            return products;
        }
    }
}
