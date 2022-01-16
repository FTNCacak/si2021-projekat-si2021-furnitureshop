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
    public class ItemBusinessTests
    {
        private Mock<IItemRepository> mockItemRepository = new Mock<IItemRepository>();

        private Item item = new Item
        {
            ProductName = "Radni sto",
            ProductPrice = 210,
            ProductColor = "gray",
            ProductDescription = "just a regular ordinary work desk for you office",
            Type = "desk",
            Category = "office",
            Stock = 7,
            Discount = 0
        };

        private List<Item> listOfItems = new List<Item>();
        private ItemBusiness itemBusiness;

        public ItemBusinessTests()
        {
            listOfItems.Add(item);
            listOfItems.Add(new Item
            {
                ProductName = "Sto",
                ProductPrice = 80,
                ProductColor = "brown",
                ProductDescription = "dinner table for kithen XD",
                Type = "desk",
                Category = "kitchen",
                Stock = 14,
                Discount = 15
            });
            listOfItems.Add(new Item
            {
                ProductName = "Chair",
                ProductPrice = 35,
                ProductColor = "black",
                ProductDescription = "uncomfortable chair for bedroom",
                Type = "chair",
                Category = "bedroom",
                Stock = 50,
                Discount = 10
        
            });
        }
        /*
         * List<item> getallitems           done
         * list<item> getinstockItems       
         * bool insertitem(item)            done
         * int updateitem(item)             done
         * int deleteitem(item)             done
         * 
         * */
        [TestMethod]
        public void GetAllItemsTest()
        {
            mockItemRepository.Setup(x => x.GetAllItems()).Returns(listOfItems);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);

            var result = itemBusiness.GetAllItems();

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void GetInStockItemsTest()
        {
            mockItemRepository.Setup(x => x.GetInStockItems()).Returns(listOfItems);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);

            var result = itemBusiness.GetInStockItems();

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void IsItemUpdated()
        {
            //arrange
            mockItemRepository.Setup(x => x.UpdateItem(item)).Returns(1);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);
            //act
            var result = itemBusiness.UpdateItem(item);
            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void IsItemDeleted()
        {
            //arrange
            mockItemRepository.Setup(x => x.DeleteItem(item.ItemID)).Returns(1);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);
            //act
            var result = itemBusiness.DeleteItem(item.ItemID);
            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsItemInserted()    //done
        {
            //arrange
            mockItemRepository.Setup(x => x.InsertItem(item)).Returns(1);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);
            //act
            var result = itemBusiness.InsertItem(item);
            //assert
            Assert.IsTrue(result);
        }
    }
}
