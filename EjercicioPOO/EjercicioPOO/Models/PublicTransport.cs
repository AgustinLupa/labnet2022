using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO.Models
{
    public abstract class PublicTransport
    {
        public int passangers { get; set; }
        public int Id { get; set; }
        public abstract string advance();
        public abstract string stop();

        public PublicTransport(int passangers, int Id)
        {
            this.passangers = passangers;
            this.Id = Id;
        }
    }
}
