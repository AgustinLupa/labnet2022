using ProyectEF.Data;
using ProyectEF.Entities;
using ProyectEF.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.Logic
{
    public class ControllerShippers
    {
        private readonly ShippersLogic shippers = new ShippersLogic();

        public List<Shippers> GetShippers()
        {
            return shippers.GetAll();
        }

        public string AddShippers(int id, string companyName, string phone)
        {
            if (companyName != "" && phone != "")
            {
                if (!ExistShipper(id))
                {
                    Shippers shipper = new Shippers(id, companyName, phone);
                    shippers.Add(shipper);
                    return "Agregado con exito";
                }
                else
                {
                    Shippers shipper = new Shippers(id, companyName, phone);
                    shippers.Update(shipper);
                    return "Se realizo la modificacion con exito";
                }
            }
                return "Faltan datos";
        }

        public bool ExistShipper(int id)
        {
            return shippers.Exist(id);
        }

        public string DeleteShippers(int id)
        {
            try
            {
                int auxId = id++;
                if (id > 0)
                {
                    if (ExistShipper(id))
                    {
                        throw new ForeingKeyException();
                        //shippers.Delete(id);
                        //return "Eliminado correctamente";
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

        public Shippers GetShipper(int id)
        {
            return shippers.GetShipper(id);
        }
    }
}
