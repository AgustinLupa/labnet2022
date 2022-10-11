using ProyectEF.Entities;
using ProyectEF.Logic;
using ProyectEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProyectEF.WebApi.Controllers
{
    public class SupplierController : ApiController
    {
        SuppliersController _suppliersController = new SuppliersController();             


        // GET: api/Supplier
        public IEnumerable<SuppliersView> Get()
        {
            return (IEnumerable<SuppliersView>)_suppliersController.List();
        }

        // GET: api/Supplier/5
        public Task <SuppliersView> Get(int id)
        {
            return _suppliersController.GetById(id);
        }

        // POST: api/Supplier
        public void Post(SuppliersView supplier)
        {
            SuppliersView suppliers = new SuppliersView()
            {
                Id = supplier.Id,
                CompanyName = supplier.CompanyName,
            };
            _suppliersController.Insert(suppliers);
        }

        // PUT: api/Supplier/5
        public void Put(SuppliersView supplier)
        {
            SuppliersView suppliers = new SuppliersView()
            {
                Id = supplier.Id,
                CompanyName = supplier.CompanyName,
            };
            _suppliersController.Update(suppliers);
        }

        // DELETE: api/Supplier/5
        public void Delete(int id)
        {
            _suppliersController.Delete(id);
        }
    }
}