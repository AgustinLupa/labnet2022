using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExtensionMethodsAndExceptions.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionMethodsAndExceptions.Controller.Tests
{
    [TestClass()]
    public class DataControllerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideNumberTest()
        {
            //Arrange
            int numberX = 1;
            DataController controller = new DataController();

            //Act
            controller.DivideNumber(numberX);            
        }

    }
}