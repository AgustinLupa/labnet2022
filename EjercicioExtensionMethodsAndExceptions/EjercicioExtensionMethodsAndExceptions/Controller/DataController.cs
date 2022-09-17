using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioExtensionMethodsAndExceptions.Exceptions;
using EjercicioExtensionMethodsAndExceptions.Models;

namespace EjercicioExtensionMethodsAndExceptions.Controller
{
    public class DataController
    {

        public void DivideNumber(int number)
        {
            
            try
            {
                int result= number / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }            
        }

        public int Exercise2Divide(string numberX, string numberY)
        {   
            
            if (numberY == "" || numberX == "")
            {
                throw new EmptyInputException("Seguro Ingreso una letra o no ingreso nada!");
            }
            int numDividend = Convert.ToInt32(numberX);
            int numDivider = Convert.ToInt32(numberY);
            if (numDivider == 0)
            {
                throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
            }            
            int result = numDividend/numDivider;
            return result;
        }

        public void Exercise3()
        {
            Logic logic = new Logic();
            logic.ExceptioLogic();
        }

        public void Exercise4()
        {
            throw new CustomException("Se ingreso a la exepcion personalizada");
        }
    }
}
