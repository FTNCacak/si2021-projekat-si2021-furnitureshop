using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using System;
using BussniessLayer;
using System.Collections.Generic;
using Shared.Models;

namespace BusinessLayerTest
{
    [TestClass]
    public class OrderItemBusinessTests
    {
        private Mock<IOrderItemRepository> mockItemOrderRepository = new Mock<IOrderItemRepository>();

        private OrderItem orderItem = new OrderItem
        {
            OrderItemID = 1,
            ItemID = 1,
            Quantity = 4,
        };

        private List<OrderItem> listOfOrders = new List<OrderItem>();
        private OrderItemBusiness orderItemBusiness;

        public OrderItemBusinessTests()
        {
            listOfOrders.Add(orderItem);
            listOfOrders.Add(new OrderItem
            {
                OrderItemID = 2,
                ItemID = 1,
                Quantity = 2,
            });
            listOfOrders.Add(new OrderItem
            {
                OrderItemID = 3,
                ItemID = 4,
                Quantity = 10,
            });
        }

        /*
         *  List<OrderItem> GetAllOrderItems();
            int InsertOrderItem(OrderItem oi);
            int UpdateOrderItem(OrderItem OrderItem);
            int DeleteOrderItem(int orderitemid);
         * */
        [TestMethod]
        public void GetAllOrderItemsTest()
        {
            mockItemOrderRepository.Setup(x => x.GetAllOrderItems()).Returns(listOfOrders);
            this.orderItemBusiness = new OrderItemBusiness(mockItemOrderRepository.Object);

            var result = orderItemBusiness.GetAllOrderItems();

            Assert.AreEqual(3, result.Count);
        }


        [TestMethod]
        public void IsOrderItemUpdated()
        {
            //arrange
            mockItemOrderRepository.Setup(x => x.UpdateOrderItem(orderItem)).Returns(1);
            this.orderItemBusiness = new OrderItemBusiness(mockItemOrderRepository.Object);
            //act
            var result = orderItemBusiness.UpdateOrderItem(orderItem);
            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void IsOrderItemDeleted()
        {
            //arrange
            mockItemOrderRepository.Setup(x => x.DeleteOrderItem(orderItem.OrderItemID)).Returns(1);
            this.orderItemBusiness = new OrderItemBusiness(mockItemOrderRepository.Object);
            //act
            var result = orderItemBusiness.DeleteItemsOrder(orderItem.OrderItemID);
            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsOrderItemInserted()    //done
        {
            //arrange
            mockItemOrderRepository.Setup(x => x.InsertOrderItem(orderItem)).Returns(1);
            this.orderItemBusiness = new OrderItemBusiness(mockItemOrderRepository.Object);
            //act
            var result = orderItemBusiness.InsertOrderItem(orderItem);
            //assert
            Assert.IsTrue(result);
        }


    }
}
