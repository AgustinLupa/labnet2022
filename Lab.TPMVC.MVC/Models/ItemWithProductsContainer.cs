using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.TPMVC.MVC.Models
{
    public class ItemWithProductsContainer
    {
        public IEnumerable<SelectListItem> products { get; set; }
        public OrderItemPresentation item { get; set; } = null;
    }
}