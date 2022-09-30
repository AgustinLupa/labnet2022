using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
