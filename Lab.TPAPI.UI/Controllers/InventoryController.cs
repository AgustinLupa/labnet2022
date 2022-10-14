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
    public class InventoryController : Controller
    {
        private static HttpClient ApiClient { get; set; }

        public InventoryController()
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

        // GET: Inventory
        public async Task<ActionResult> Index()
        {
            string url = "https://localhost:44354/api/Orders";

            try
            {
                var json = await ApiClient.GetStringAsync(url);

                var orders = JsonConvert.DeserializeObject<List<OrderPresentation>>(json);

                return View(orders);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }

        // GET: Inventory/ViewDetails/{orderId}
        public async Task<ActionResult> ViewDetails(int orderId)
        {
            try
            {
                string url = $"https://localhost:44354/api/Item?orderId={orderId}";

                var json = await ApiClient.GetStringAsync(url);

                var items = JsonConvert.DeserializeObject<List<OrderItemPresentation>>(json);

                return View(items);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }


        public async Task<ActionResult> DeleteItem(int orderId, int productId)
        {
            try
            {
                string url = $"https://localhost:44354/api/Item?orderId={orderId}&productId={productId}";

                await ApiClient.DeleteAsync(url);

                return RedirectToAction("ViewDetails", new { orderId });
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }

        public async Task<ActionResult> AddOrEditItem(int orderId, int? productId = null)
        {
            try
            {

                string url = $"https://localhost:44354/api/Product";
                var json = await ApiClient.GetStringAsync(url);
                var products = JsonConvert.DeserializeObject<List<ProductPresentation>>(json);
                var set = new ItemWithProductsContainer
                {
                    products = products
                };

                if (productId != null)
                {
                    url = $"https://localhost:44354/api/Orders/{orderId}";

                    json = await ApiClient.GetStringAsync(url);

                    var order = JsonConvert.DeserializeObject<OrderPresentation>(json);

                    var order_details = order.Order_Details.FirstOrDefault(d => d.ProductID == productId);
                    set.item = order_details;
                }
                else
                {
                    set.item = new OrderItemPresentation { OrderID = orderId };
                }

                return View(set);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }

        public async Task<ActionResult> AddItem(ItemWithProductsContainer order)
        {
            try
            {
                var item = order.item;
                string url = $"https://localhost:44354/api/Item";
                await ApiClient.PostAsJsonAsync(url, item);
                return RedirectToAction("ViewDetails", new { item.OrderID });
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }

        public async Task<ActionResult> EditItem(ItemWithProductsContainer order)
        {
            try
            {
                var item = order.item;
                string url = $"https://localhost:44354/api/Item";
                await ApiClient.PutAsJsonAsync(url, item);
                return RedirectToAction("ViewDetails", new { item.OrderID });
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Shared");
            }
        }
    }
}