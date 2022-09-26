using ProyectEF.Data;
using ProyectEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.Logic
{
    public class SuppliersLogic : BaseLogic ,ILogic<Suppliers>
    {
        public void Add(Suppliers item)
        {
            _context.suppliers.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var suppliersToDelete = _context.suppliers.Find(id);
            _context.suppliers.Remove(suppliersToDelete);
            _context.SaveChanges();
        }

        public bool Exist(int id)
        {
            var supplierExist = _context.suppliers.Find(id);
            if(supplierExist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Suppliers> GetAll()
        {
            return _context.suppliers.ToList();
        }

        public void Update(Suppliers item)
        {
            var supplierUpdate = _context.suppliers.Find(item.SupplierID);
            supplierUpdate.City = item.City;
            supplierUpdate.Country = item.Country;
            supplierUpdate.Address = item.Address;
            supplierUpdate.HomePage = item.HomePage;
            supplierUpdate.CompanyName = item.CompanyName;
            supplierUpdate.ContactName = item.ContactName;
            supplierUpdate.ContactTitle = item.ContactTitle;
            supplierUpdate.Fax = item.Fax;
            supplierUpdate.Phone = item.Phone;
            supplierUpdate.PostalCode = item.PostalCode;
            supplierUpdate.Region = item.Region;
            _context.SaveChanges();
        }

        public Suppliers GetSupplier(int id)
        {
            List<Suppliers> auxSuppliers = GetAll();
            foreach (var item in auxSuppliers)
            {
                if(item.SupplierID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
