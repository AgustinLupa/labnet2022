using Lab.TP4.Data;
using Lab.TP4.Entities;
using Lab.TP4.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Lab.TP4.Tests
{
    [TestClass]
    public class Order_DetailsLogicTest
    {
        [TestMethod]
        public void OrderDetailsLogic_AddOrder_WorksProperly()
        {
            var mockSet = new Mock<DbSet<Order_Details>>();

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.GetOrder_Details()).Returns(mockSet.Object);

            Order_DetailsLogic service = new Order_DetailsLogic(mockContext.Object);
            service.Add(new Order_Details()
            {
                OrderID = 10248,
                ProductID = 2,
                UnitPrice = 0,
                Quantity = 1,
                Discount = 0,
            });

            mockSet.Verify(m => m.Add(It.IsAny<Order_Details>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void OrderDetailsLogic_GetAllEntries()
        {
            var data = new List<Order_Details>
            {
                new Order_Details{OrderID = 0, ProductID = 0},
                new Order_Details{OrderID = 1, ProductID = 1},
                new Order_Details{OrderID = 2, ProductID = 2},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Order_Details>>();
            mockSet.As<IQueryable<Order_Details>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Order_Details>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Order_Details>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Order_Details>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.GetOrder_Details()).Returns(mockSet.Object);

            var service = new Order_DetailsLogic(mockContext.Object);
            var order_details = service.GetAll();

            Assert.IsNotNull(order_details);
            Assert.AreEqual(3, order_details.Count);
            Assert.AreEqual(0, order_details[0].OrderID);
            Assert.AreEqual(1, order_details[1].OrderID);
            Assert.AreEqual(2, order_details[2].OrderID);
        }
    }
}
