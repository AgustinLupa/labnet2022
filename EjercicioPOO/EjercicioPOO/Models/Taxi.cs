using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO.Models
{
    internal class Taxi : PublicTransport
    {
        public Taxi(int passangers, int id) : base(passangers, id)
        {

        }

        public override string advance()
        {
            return $"El taxi esta avanzando con {this.passangers} pasajeros";
        }

        public override string stop()
        {
            return $"El taxi freno transportando {this.passangers} pasajeros";
        }

        public override string ToString()
        {
            return $"El taxi {this.Id} tiene: {this.passangers} pasajeros";
        }
    }
}
