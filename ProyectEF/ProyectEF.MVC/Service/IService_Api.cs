using ProyectEF.Entities;
using ProyectEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.WebApi.Service
{
    public interface IService_Api
    {
        Task<List<Shippers>> ListShipper();
        Task<List<Suppliers>> ListSuppliers();
        Task<Suppliers> GetSuppliers(int id);
        Task<Shippers> GetShippers(int id);
        Task SaveSuppliers(Suppliers suppliersView);
        Task SaveShippers(Shippers shippersView);
        Task DeleteSuppliers(int id);
        Task DeleteShippers(int id);
        Task EditSuppliers(Suppliers suppliersView);
        Task EditShippers(Shippers shippersView);
    }
}
