using ProyectEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectEF.WebApi.Models
{
    public class ResultApiShippers
    {
        public string Message { get; set; }
        public List<Shippers> List { get; set; }
        public Shippers shippers { get; set; }
    }
}