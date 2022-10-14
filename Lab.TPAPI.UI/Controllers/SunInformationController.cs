using Lab.TPAPI.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.TPAPI.UI.Controllers
{
    public class SunInformationController : Controller
    {
        private static HttpClient ApiClient { get; set; }

        public SunInformationController()
        {
            InitializeClient();
        }

        private static void InitializeClient()
        {
            if (ApiClient == null)
            {
                ApiClient = new HttpClient();
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        // GET: SunInformation
        public async Task<ActionResult> Index()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=-38.00042&lng=-57.5562&date=today";

            var json = await ApiClient.GetStringAsync(url);

            SunResultModel result = JsonConvert.DeserializeObject<SunResultModel>(json);

            SunModel sunModel = new SunModel
            {
                Sunrise = result.Results.Sunrise.ToLocalTime(),
                Sunset = result.Results.Sunset.ToLocalTime()
            };

            return View(sunModel);
        }
    }
}