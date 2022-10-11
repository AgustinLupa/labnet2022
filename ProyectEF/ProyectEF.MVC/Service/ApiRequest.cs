using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ProyectEF.MVC.Models
{
    public class ApiRequest
    {
        public string Url { get; set; }
        private int actualy = 0;

        public ApiRequest()
        {

            this.Url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=0";
        }

        public PokemonList GetResult()
        {
            var consul = (HttpWebRequest)WebRequest.Create(Url + actualy);
            consul.Method = "GET";
            consul.ContentType = "application/json";
            consul.Accept = "application/json";

            try
            {
                using(WebResponse response = consul.GetResponse())
                {
                    using(Stream stream = response.GetResponseStream())
                    {
                        if (stream != null)
                        {
                            return null;
                        }
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string responseText = reader.ReadToEnd();

                            PokemonList pokemon = JsonConvert.DeserializeObject<PokemonList>(responseText);
                            actualy += 10;
                            return pokemon;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}