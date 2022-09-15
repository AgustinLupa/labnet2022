using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO.Models
{
    internal class Omnibus : PublicTransport
    {
        public Omnibus(int passangers, int id) : base(passangers,id)
        {
        }

        public override string advance()
        {
            return $"El omnibus esta avanzando con {this.passangers} pasajeros";
        }

        public override string stop()
        {
            return $"El omnibus freno transportando {this.passangers} pasajeros";
        }

        public override string ToString()
        {
            return $"El omnibus {this.Id} tiene: {this.passangers} pasajeros";
        }
    }
}
