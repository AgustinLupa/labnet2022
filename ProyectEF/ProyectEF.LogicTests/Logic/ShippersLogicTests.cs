using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ProyectEF.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void ExistTest()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            int id=1;
            bool existShipper = shippersLogic.Exist(id);
            Assert.AreEqual(true, existShipper);
        }
    }
}