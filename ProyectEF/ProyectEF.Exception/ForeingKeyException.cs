using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.Exceptions
{
    public class ForeingKeyException : Exception
    {
        public ForeingKeyException() : base("No se puede borrar porque se encuentra ligada con otros datos")
        {

        }
    }
}
