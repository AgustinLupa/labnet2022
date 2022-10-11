using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectEF.MVC.Models
{
    public class PokemonList
    {
        [JsonProperty("Count")]
        public long Count { get; set; }
        [JsonProperty("Next")]
        public Uri Next { get; set; }
        [JsonProperty("Previous")]
        public object Previous { get; set; }
        [JsonProperty("Results")]
        public List<Pokemon> PokemonsList { get; set; }
    }
}