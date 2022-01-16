using BussniessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayerTest
{
    [TestClass]
    public class OrderBusinessTests
    {
        private Mock<IOrderRepository> mockOrderRepository = new Mock<IOrderRepository>();

        private Order order = new Order
        {
            OrderID = 1,
            EmployeeID = 1,
            OrderDate = DateTime.Now,
            Bill = 155
        };

        private List<Order> listOfOrders = new List<Order>();
        private OrderBusiness orderBusiness;

        public OrderBusinessTests()
        {
            listOfOrders.Add(order);
            listOfOrders.Add(new Order
            {
                OrderID = 2,
                EmployeeID = 2,
                OrderDate = DateTime.Now,
                Bill = 200
            });
        }
        /*
         * list order getallorders//
         * int insertorder order    //
         * int updateorder order//
         * int deleteorder order//
         * 
         * */
        [TestMethod]
        public void GetAllOrdersTest()
        {
            mockOrderRepository.Setup(x => x.GetAllOrders()).Returns(listOfOrders);
            this.orderBusiness = new OrderBusiness(mockOrderRepository.Object);

            var result = orderBusiness.GetAllOrders();

            Assert.AreEqual(2, result.Count);
        }

        

        [TestMethod]
        public void IsOrderUpdated()
        {
            //arrange
            mockOrderRepository.Setup(x => x.UpdateOrder(order)).Returns(1);
            this.orderBusiness = new OrderBusiness(mockOrderRepository.Object);
            //act
            var result = orderBusiness.UpdateOrder(order);
            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void IsOrderDeleted()
        {
            //arrange
            mockOrderRepository.Setup(x => x.DeleteOrder(order.OrderID)).Returns(1);
            this.orderBusiness = new OrderBusiness(mockOrderRepository.Object);
            //act
            var result = orderBusiness.DeleteOrder(order.OrderID);
            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsOrderInserted()    //done
        {
            //arrange
            mockOrderRepository.Setup(x => x.InsertOrder(order)).Returns(1);
            this.orderBusiness = new OrderBusiness(mockOrderRepository.Object);
            //act
            var result = orderBusiness.InsertOrder(order);
            //assert
            Assert.IsTrue(result);
        }
    }
}
