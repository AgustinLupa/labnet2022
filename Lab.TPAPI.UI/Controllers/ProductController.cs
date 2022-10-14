using Lab.TP4.Logic;
using Lab.TPAPI.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab.TPAPI.UI.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private readonly ProductsLogic _productsLogic = LogicController.GetProductsLogic();

        // GET: api/Product
        [HttpGet]
        public List<ProductPresentation> Get()
        {
            var result = _productsLogic.GetAll().Select(p => new ProductPresentation
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice
            }).ToList();

            return result;
        }

        // GET: api/Product/5
        [HttpGet]
        public ProductPresentation Get(int id)
        {
            var product = _productsLogic.GetById(id);

            var result = new ProductPresentation
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice
            };

            return result;
        }
    }
}
