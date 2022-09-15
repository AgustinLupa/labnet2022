using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPOO.Data;
using EjercicioPOO.Models;

namespace EjercicioPOO.Controller
{
    internal class ControllerTransport
    {   
        int contOmnibus=1;
        int contTaxi = 1;
        PublicTransportList lPublicTransport = new PublicTransportList();
        public string AddOmnibus(int passangers)
        {
            if(lPublicTransport.OmnibusListIsFull())
            {
                return "Solo se pueden ingresar 5 omnibus";
            }
            else
            {
                Omnibus omnibus = new Omnibus(passangers, contOmnibus);
                lPublicTransport.AddTransport(omnibus, "Omnibus");
                return "Omnibus cargado con exito";                
            }
        }
        
        public string AddTaxi(int passangers)
        {
            if (lPublicTransport.TaxiListIsFull())
            {
                return "Solo se pueden ingresar 5 Taxis";
            }
            else
            {
                if(passangers <= 4)
                {
                    Taxi taxi = new Taxi(passangers, contTaxi);
                    lPublicTransport.AddTransport(taxi, "Taxi");
                    return "Taxis cargado con exito";
                }
                return "No puede tener mas de 4 pasajeros el Taxi";              
            }
        }

        public string RemoveTransport(int position)
        {
            if (position >= 0)
            {
                lPublicTransport.DeleteTransport(position);
                return "Eliminado con exito";
            }
            return "No se puedo eliminar";
        }
        
        public List<PublicTransport> PublicTransport()
        {
            lPublicTransport.SortList();
            return lPublicTransport.ListPublicTransport();
        }

        public void SortList()
        {
            lPublicTransport.SortList();
        }
    }
}
