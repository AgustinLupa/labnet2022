using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.TPMVC.MVC.Models
{
    public class ProductPresentation : SelectListItem
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}