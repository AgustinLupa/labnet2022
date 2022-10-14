using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.TPAPI.UI.Models
{
    public class OrderPresentation
    {
        [Display(Name = "Order ID")]
        [Range(10000, 99999, ErrorMessage ="Not a valid Order ID")]
        public int OrderID { get; set; }

        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; }

        [Display(Name = "Employee ID")]
        public int? EmployeeID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Required Date")]
        public DateTime? RequiredDate { get; set; }

        [Display(Name = "Shipped Date")]
        public DateTime? ShippedDate { get; set; }

        public List<OrderItemPresentation> Order_Details { get; set; }

    }
}