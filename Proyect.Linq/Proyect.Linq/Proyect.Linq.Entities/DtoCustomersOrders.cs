using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.Linq.Entities
{
    public class DtoCustomersOrders
    {
        public int OrderID { get; set; }
        public string ContactName { get; set; }
        public string Region { get; set; }
        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            return $"Order: {this.OrderID}, for: {this.ContactName}, region: {this.Region}, Fecha: {this.OrderDate}";
        }
    }
}
