using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionMethodsAndExceptions.Exceptions
{
    internal class EmptyInputException : Exception
    {
        public EmptyInputException(string message) : base(message)
        {
            
        }
    }
}
