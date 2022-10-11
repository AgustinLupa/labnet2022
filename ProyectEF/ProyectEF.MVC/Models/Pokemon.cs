using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectEF.MVC.Models
{
    public partial class Pokemon
    {
        [JsonProperty ("Name")]
        public string Name { get; set; }
        [JsonProperty ("Uri")]
        public Uri Url { get; set; }
    }
}