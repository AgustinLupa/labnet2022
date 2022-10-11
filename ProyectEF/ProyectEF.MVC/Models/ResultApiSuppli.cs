using ProyectEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectEF.MVC.Models
{
    public class ResultApiSuppli
    {
        public string Message { get; set; }
        public List<Suppliers> List { get; set; }
        public Suppliers suppliers { get; set; }
    }
}