using Lab.TP4.Data;
using Lab.TP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Logic
{
    public class ProductsLogic : BaseLogic<Products>
    {
        public ProductsLogic(IDataConnection context) : base(context)
        {
        }

        public override void Add(Products item)
        {
            throw new NotImplementedException();
        }

        public override List<Products> GetAll()
        {
            return _context.GetProducts().ToList();
        }

        public override Products GetById(int productId)
        {
            var product = _context.GetProducts().Find(productId);

            if (product == null)
                throw new InvalidOperationException("No Product with such ID was found");
            return product;
        }

        public override void Remove(Products product)
        {
            throw new NotImplementedException();
        }

        public override void Update(Products item)
        {
            throw new NotImplementedException();
        }
    }
}
