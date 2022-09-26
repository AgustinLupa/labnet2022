using ProyectEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.Logic
{
    public class BaseLogic 
    {
        protected readonly NorthwindContext _context;
        public BaseLogic()
        {
                this._context = new NorthwindContext();
        }
    }
}
