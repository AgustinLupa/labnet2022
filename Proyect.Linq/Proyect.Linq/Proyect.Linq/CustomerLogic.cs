using Proyect.Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
