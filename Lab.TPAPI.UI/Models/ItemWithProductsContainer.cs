using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.TPAPI.UI.Models
{
    public class ItemWithProductsContainer
    {
        public List<ProductPresentation> products { get; set; }
        public OrderItemPresentation item { get; set; } = null;
    }
}