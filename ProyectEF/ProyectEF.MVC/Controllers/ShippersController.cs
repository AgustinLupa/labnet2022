using Microsoft.Win32;
using ProyectEF.Entities;
using ProyectEF.Logic;
using ProyectEF.MVC.Models;
using ProyectEF.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using ProyectEF.WebApi;
using ProyectEF.WebApi.Service;

namespace ProyectEF.MVC.Controllers
{
    public class ShippersController : Controller
    {        
        ShippersLogic logic = new ShippersLogic();
        private readonly IService_Api serv;

        public ShippersController()
        {
            this.serv = new Service_Api();
        }


        // GET: Shippers
        public async Task<ActionResult> Index()
        {
            List<Shippers> shippers = await serv.ListShipper();
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID.ToString(),
                CompanyName = s.CompanyName,
            }).ToList();            
            ViewBag.Shippers = shippersView;
            return View(shippersView);
        }

        public async Task<List<ShippersView>> List()
        {            
            List<Shippers> shippers = await serv.ListShipper(); ;
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID.ToString(),
                CompanyName = s.CompanyName,
            }).ToList();
            return shippersView;
        }

        public async Task<ShippersView> GetById(int id)
        {
            Shippers shippers = await serv.GetShippers(id);
            ShippersView shippersView = new ShippersView
            {
                Id = shippers.ShipperID.ToString(),
                CompanyName = shippers.CompanyName,
            };
            return shippersView;
        }

        [HttpPost]
        public async Task<ActionResult> Insert(ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers { CompanyName = shippersView.CompanyName };
                if(shipperEntity.CompanyName != null)
                {
                    foreach (char item in shippersView.CompanyName)
                    {
                        if((item >= 33 && item <= 64) || (item >= 91 && item <=96) || (item >= 123 && item <= 255))
                        {
                            throw new FormatException();
                        }
                    }
                }                
                await serv.SaveShippers(shipperEntity);
                return RedirectToAction("Index");
            }
            catch(FormatException)
            {
                return RedirectToAction("ViewFormatException", "Error");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                return RedirectToAction("ViewDbEntityValidation", "Error");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await serv.DeleteShippers(id);
                return RedirectToAction("Index");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return RedirectToAction("ViewDbUpdateException", "Error");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }            
        }

        [HttpPost]
        public async Task <ActionResult> Update(ShippersView shippersView)
        {
            try
            {
                Shippers shippers = new Shippers()
                {
                    CompanyName = shippersView.CompanyName
                };
                
                if (shippers.CompanyName != null && shippersView.Id != null)
                {
                    foreach (char item in shippersView.CompanyName)
                    {
                        if ((item >= 33 && item <= 64) || (item >= 91 && item <= 96) || (item >= 123 && item <= 255))
                        {
                            throw new FormatException();
                        }
                    }
                    foreach (char item in shippersView.Id)
                    {
                        if (item <= 48 && item >= 58)
                        {
                            throw new FormatException();
                        }
                    }
                    await serv.EditShippers(shippers);
                }
                else
                {
                    throw new NullStringException();
                }
                return RedirectToAction("Index");
            }
            catch (NullStringException)
            {
                return RedirectToAction("ViewDbEntityValidation", "Error");
            }
            catch (FormatException)
            {
                return RedirectToAction("ViewFormatException", "Error");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}