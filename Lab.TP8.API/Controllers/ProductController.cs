using Lab.TP4.Entities;
using Lab.TP4.Logic;
using Lab.TP8.API.Models;
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
        public Result Get()
        {
            Result result = new Result();

            result.response = _productsLogic.GetAll().Select(p => new ProductPresentation
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice
            }).ToList();

            result.successful = true;
            result.message = "OK";

            return result;
        }

        // GET: api/Product/5
        [HttpGet]
        public Result Get(int id)
        {
            Result result = new Result();

            try
            {
                var product = _productsLogic.GetById(id);

                result.response = new ProductPresentation
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice
                };

                result.successful = true;
                result.message = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result.message = ex.Message;

                return result;
            }
        }

        // POST: api/Product
        [HttpPost]
        public Result Post(ProductPresentation item)
        {
            var productPresentation = new Products()
            {               
                ProductID = item.ProductID,
                UnitPrice = item.UnitPrice,
                ProductName = item.ProductName,
            };
            try
            {
                _productsLogic.Add(productPresentation);

                return new Result(true, "OK", "");
            }
            catch (Exception ex)
            {
                return new Result(ex.Message);
            }
        }

        // PUT: api/Product
        [HttpPut]
        public Result Put(ProductPresentation item)
        {
            var product = new Products()
            {                
                ProductID = item.ProductID,
                UnitPrice = item.UnitPrice,
                ProductName = item.ProductName,
            };
            try
            {
                _productsLogic.Update(product);

                return new Result(true, "OK", "");
            }
            catch (Exception ex)
            {
                return new Result(ex.Message);
            }
        }

        // DELETE: api/Product
        [HttpDelete]
        public Result Delete(int productId)
        {
            var toDelete = new Products()
            {
                ProductID = productId
            };

            try
            {
                _productsLogic.Remove(toDelete);
                return new Result(true, "OK", "");
            }
            catch (Exception ex)
            {
                return new Result(ex.Message);
            }
        }
    }
}
