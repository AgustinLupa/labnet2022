using ProyectEF.Entities;
using ProyectEF.Exceptions;
using ProyectEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectEF.MVC.Models
{
    public class SuppliersController : Controller
    {
        SuppliersLogic logic = new SuppliersLogic();
        // GET: Suppliers
        public ActionResult Index()
        {
            SupplierView auxSupplierView = new SupplierView();
            List<Suppliers> suppliers = logic.GetAll();
            List<SupplierView> supplierView = suppliers.Select(s => new SupplierView
            {
                Id = s.SupplierID.ToString(),
                CompanyName = s.CompanyName,
            }).ToList();
            ViewBag.Suppliers = supplierView;
            return View(auxSupplierView);
        }

        [HttpPost]
        public ActionResult Insert(SupplierView supplierView)
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
                logic.Add(suppliersEntity);
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
                logic.Delete(id);
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
        public ActionResult Update(SupplierView supplierView)
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
                logic.Update(suppliersEntity);
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