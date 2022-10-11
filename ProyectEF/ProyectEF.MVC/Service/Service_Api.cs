using ProyectEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using System.Text;
using Newtonsoft.Json;
using ProyectEF.WebApi;
using ProyectEF.Entities;
using Microsoft.Ajax.Utilities;
using ProyectEF.WebApi.Models;

namespace ProyectEF.WebApi.Service
{    
    public class Service_Api : IService_Api
    {
        
                
        public async Task DeleteShippers(int id)
        {
            Shippers auxShippers = new Shippers();
            var shipper = new HttpClient();
            shipper.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");            
            var response = await shipper.DeleteAsync("api/Shipper/5");
        }

        public async Task DeleteSuppliers(int id)
        {
            Suppliers auxSuppliers = new Suppliers();
            var suppliers = new HttpClient();
            suppliers.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var response = await suppliers.DeleteAsync("api/Supplier/5"); ;
        }

        public async Task EditShippers(Shippers shippers)
        {
            Shippers auxShippers = new Shippers();
            var shipper = new HttpClient();
            shipper.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var content = new StringContent(JsonConvert.SerializeObject(auxShippers), Encoding.UTF8, "application/json");
            var response = await shipper.PutAsync("api/Shipper/5", content);
        }

        public async Task EditSuppliers(Suppliers suppliers)
        {
            Suppliers auxSuppliers = new Suppliers();
            var suppliers1 = new HttpClient();
            suppliers1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var content = new StringContent(JsonConvert.SerializeObject(auxSuppliers), Encoding.UTF8, "application/json");
            var response = await suppliers1.PutAsync("api/Supplier/5", content);
        }

        public async Task<Shippers> GetShippers(int id)
        {
            Shippers shippers = new Shippers();
            var shipper = new HttpClient();
            shipper.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var response = await shipper.GetAsync($"api/Shipper/5{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultApiShippers>(json);
                shippers = result.shippers;
            }
            return shippers;
        }

        public async Task<Suppliers> GetSuppliers(int id)
        {
            Suppliers suppliers= new Suppliers();
            var suppliers1 = new HttpClient();
            suppliers1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var response = await suppliers1.GetAsync($"api/Supplier/5{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultApiSuppli>(json);
                suppliers = result.suppliers;
            }
            return suppliers;
        }

        public async Task<List<Shippers>> ListShipper()
        {
            List<Shippers> shippers = new List<Shippers>();
            var shipper = new HttpClient();
            shipper.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var response = await shipper.GetAsync("api/Shipper");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultApiShippers>(json);
                shippers = result.List;
            }
            return shippers;
        }

        public async Task<List<Suppliers>> ListSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            var supplier = new HttpClient();
            supplier.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var response = await supplier.GetAsync("api/Supplier");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultApiSuppli>(json);
                suppliers = result.List;
            }
            return suppliers;
        }

        public async Task SaveShippers(Shippers shippers)
        {
            Shippers auxShippers = new Shippers();
            var shipper = new HttpClient();
            shipper.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var content = new StringContent(JsonConvert.SerializeObject(auxShippers), Encoding.UTF8, "application/json");
            var response = await shipper.PostAsync("api/Shipper/", content);
        }

        public async Task SaveSuppliers(Suppliers suppliersView)
        {
            Suppliers auxSuppliers = new Suppliers();
            var supplier = new HttpClient();
            supplier.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
            var content = new StringContent(JsonConvert.SerializeObject(auxSuppliers), Encoding.UTF8, "application/json");
            var response = await supplier.PostAsync("api/Supplier/", content);
        }
    }
}