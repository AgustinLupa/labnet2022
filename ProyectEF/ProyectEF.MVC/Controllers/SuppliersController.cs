using ProyectEF.Entities;
using ProyectEF.Exceptions;
using ProyectEF.Logic;
using ProyectEF.WebApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProyectEF.MVC.Models
{
    public class SuppliersController : Controller
    {
        SuppliersLogic logic = new SuppliersLogic();
        IService_Api _serv;

        public SuppliersController()
        {
            this._serv = new Service_Api();
        }
        // GET: Suppliers
        public async Task <ActionResult> Index()
        {
            SuppliersView auxSupplierView = new SuppliersView();
            List<Suppliers> suppliers = await _serv.ListSuppliers();
            List<SuppliersView> supplierView = suppliers.Select(s => new SuppliersView
            {
                Id = s.SupplierID.ToString(),
                CompanyName = s.CompanyName,
            }).ToList();
            ViewBag.Suppliers = supplierView;
            return View(auxSupplierView);
        }

        public async Task <List<SuppliersView>> List()
        {
            List<Suppliers> suppliers = await _serv.ListSuppliers();
            List<SuppliersView> suppliersView = suppliers.Select(s => new SuppliersView
            {
                Id = s.SupplierID.ToString(),
                CompanyName = s.CompanyName,
            }).ToList();
            return suppliersView;
        }

        public async Task <SuppliersView> GetById(int id)
        {
            Suppliers suppliers = await _serv.GetSuppliers(id);            
            SuppliersView auxSuppliersView = new SuppliersView();
            if (id > 0)
            {
                auxSuppliersView.Id = id.ToString();
                auxSuppliersView.CompanyName = suppliers.CompanyName;
            }
            return auxSuppliersView;
        }

        [HttpPost]
        public ActionResult Insert(SuppliersView supplierView)
        {
            try
            {
                Suppliers suppliersEntity = new Suppliers { CompanyName = supplierView.CompanyName };
                if (suppliersEntity.CompanyName != null)
                {
                    foreach (char item in supplierView.CompanyName)
                    {
                        if ((item >= 33 && item <= 64) || (item >= 91 && item <= 96) || (item >= 123 && item <= 255))
                        {
                            throw new FormatException();
                        }
                    }
                }
                _serv.SaveSuppliers(suppliersEntity);
                return RedirectToAction("Index");
            }
            catch (FormatException)
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
        public ActionResult Delete(int id)
        {
            try
            {
                _serv.DeleteSuppliers(id);
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
        public ActionResult Update(SuppliersView supplierView)
        {
            try
            {
                Suppliers suppliersEntity = new Suppliers
                {
                    CompanyName = supplierView.CompanyName,
                    SupplierID = Convert.ToInt32(supplierView.Id)
                };
                if (suppliersEntity.CompanyName != null && supplierView.Id != null)
                {
                    foreach (char item in supplierView.CompanyName)
                    {
                        if ((item >= 33 && item <= 64) || (item >= 91 && item <= 96) || (item >= 123 && item <= 255))
                        {
                            throw new FormatException();
                        }
                    }
                    foreach (char item in supplierView.Id)
                    {
                        if (item <= 48 && item >= 58)
                        {
                            throw new FormatException();
                        }
                    }
                }
                else
                {
                    throw new NullStringException();
                }
                _serv.EditSuppliers(suppliersEntity);
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