using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPOO.Models;

namespace EjercicioPOO.Data
{
    public class PublicTransportList
    {
        public int contOmnibus = 0;
        public int contTaxi = 0;

        private List <PublicTransport> listPublicTransport = new List <PublicTransport> ();

        public void AddTransport(PublicTransport publicTransport, string type)
        {
            this.listPublicTransport.Add(publicTransport);
            if(type == "Taxi")
            {
                contTaxi++;
            }
            else
            {
                contOmnibus++;
            }
        }

        public void DeleteTransport(int position)
        {
            PublicTransport publicTransport = this.listPublicTransport[position];            
            this.listPublicTransport.RemoveAt(position);
            if(publicTransport is Taxi)
            {
               contTaxi--;
            }
            else
            {
                contOmnibus--;
            }
        }
        
        public bool OmnibusListIsFull()
        {
            if (contOmnibus == 5)
            {
                return true;
            }
            return false;
        }

        public bool TaxiListIsFull()
        {
            if(contTaxi == 5)
            {
                return true;
            }
            return false;
        }

        public List<PublicTransport> ListPublicTransport()
        {
            return this.listPublicTransport;
        }

        public void SortList()
        {
            int auxContTaxi = 1, auxCountOmnibus = 1;
            foreach (PublicTransport publicTransport in this.listPublicTransport)
            {
                if(publicTransport is Taxi)
                {
                    publicTransport.Id = auxContTaxi;
                    auxContTaxi++;
                }
                else
                {
                    publicTransport.Id = auxCountOmnibus;
                    auxCountOmnibus++;
                }
            }
        }
    }
}
