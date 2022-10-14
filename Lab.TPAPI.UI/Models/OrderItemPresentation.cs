using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.TPAPI.UI.Models
{
    public class OrderItemPresentation
    {
        [Required(ErrorMessage = "You must provide an Order ID for this Order Item.")]
        [Display(Name = "Order ID")]
        [Range(10000, 99999, ErrorMessage = "Not a valid Order ID.")]
        public int OrderID { get; set; }

        [Display(Name = "Product ID")]
        [Required(ErrorMessage = "You must provide a Product for this Order Item.")]
        [Range(1, 10000, ErrorMessage = "Not a valid Product ID.")]
        public int ProductID { get; set; }

        [Display(Name = "Product")]
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "A Unit Price is required.")]
        [Display(Name = "Unit Price")]
        [Range(0, 10000, ErrorMessage ="Not a valid Unit Price value.")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "You must specify an item amount.")]
        [Range(1, 10000, ErrorMessage = "Not a valid item Quantity value.")]
        public short Quantity { get; set; }

        [Required(ErrorMessage = "You must specify a discount.")]
        [Range(0, 1, ErrorMessage = "Not a valid Discount value.")]
        public float Discount { get; set; }

    }
}