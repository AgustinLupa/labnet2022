using ProyectEF.Entities;
using ProyectEF.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.Logic
{
    public class ControllerSuppliers
    {
        private readonly SuppliersLogic suppliers = new SuppliersLogic();

        public List<Suppliers> GetSupliers()
        {
            return suppliers.GetAll();
        }

        public string AddSuppliers(int id, string companyName, string phone, 
            string country, string city, string address, string homePage,
            string contactName, string contactTitle, string fax,
            string postalCode)
        {
            if (companyName != "")
            {
                if (!ExistSupplier(id))
                {
                    Suppliers supplier = new Suppliers(id, companyName, 
                        phone, country, city, address, homePage,
                        contactName, contactTitle, fax,
                        postalCode);
                    suppliers.Add(supplier);
                    return "Agregado con exito";
                }
                else
                {
                    Suppliers supplier = new Suppliers(id, companyName, phone,
                       country, city, address, homePage,
                       contactName, contactTitle, fax,
                       postalCode);
                    suppliers.Update(supplier);
                    return "Se realizo la modificacion con exito";
                }
            }
            return "Falta Nombre de la compania";
        }

        public bool ExistSupplier(int id)
        {
            return suppliers.Exist(id);
        }

        public string DeleteShippers(int id)
        {
            try
            {
                int auxId = id++;
                if (id > 0)
                {
                    if (ExistSupplier(id))
                    {
                        throw new ForeingKeyException();
                        /*suppliers.Delete(id);
                        return "Eliminado correctamente";
                        */
                    }
                    else
                    {
                        return "Ocurrio un error inesperado";
                    }
                }
                return "No Selecciono un item";
            }
            catch (ForeingKeyException fex)
            {
                return fex.Message;
            }
        }

        public Suppliers GetSupplier(int id)
        {
            return suppliers.GetSupplier(id);
        }

    }
}
