using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectEF.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        // GET: Error FormatException
        public ActionResult ViewFormatException()
        {
            return View();
        }

        // GET: Error System.Data.Entity.Validation.DbEntityValidationException
        public ActionResult ViewDbEntityValidation()
        {
            return View();
        }

        // GET: Error System.Data.Entity.Infrastructure.DbUpdateException
        public ActionResult ViewDbUpdateException()
        {
            return View();
        }
    }
}