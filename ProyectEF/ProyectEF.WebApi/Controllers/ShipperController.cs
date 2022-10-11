using Microsoft.Ajax.Utilities;
using ProyectEF.Entities;
using ProyectEF.MVC.Models;
using ProyectEF.WebApi.Service;
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
    public class ShipperController : ApiController
    {         
        private readonly IService_Api service_Api;

        public ShipperController(IService_Api service_Api)
        {
            this.service_Api = service_Api;
        }

        public ShipperController() { }

        // GET: api/Shipper
        public async Task<IEnumerable<ShippersView>> Get()
        {
            List<Shippers> shippers = await service_Api.ListShipper();
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID.ToString(),
                CompanyName = s.CompanyName,
            }).ToList();            
            return shippersView;
        }

        // GET: api/Shipper/5
        public async Task<ShippersView> Get(int id)
        {
            Shippers shippers =  await service_Api.GetShippers(id);
            ShippersView shippersView = new ShippersView
            {
                Id = shippers.ShipperID.ToString(),
                CompanyName = shippers.CompanyName,
            };
            return shippersView;
        }

        // POST: api/Shipper
        public async void Post(ShippersView shippersView)
        {
            Shippers shippers = new Shippers()
            {
                CompanyName = shippersView.CompanyName
            };
            await service_Api.SaveShippers(shippers);
        }

        // PUT: api/Shipper/5
        public async void Put(int id, Shippers shippersView)
        {
            Shippers shippers = new Shippers()
            {
                ShipperID = id,
                CompanyName = shippersView.CompanyName
            };
            await service_Api.EditShippers(shippers);
        }

        // DELETE: api/Shipper/5
        public async void Delete(int id)
        {
            await service_Api.DeleteShippers(id);
        }
    }
}
