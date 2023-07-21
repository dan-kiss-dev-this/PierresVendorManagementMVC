using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorManager.Models;
using System.Collections.Generic;
using System;

namespace OrderManager.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreateInstanceOfOrder_Order()
        {
            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_CanReturnName_String()
        {
            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);
            Assert.AreEqual(title, newOrder.Title);
        }

        [TestMethod]
        public void GetDescription_CanReturnDescription_String()
        {
            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);
            Assert.AreEqual(description, newOrder.Description);
        }

        [TestMethod]
        public void GetId_CanReturnId_Int()
        {
            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);
            string title2 = "Order for Amy";
            string description2 = "Dozen cookies";
            int price2 = 20;
            Order newOrder2 = new Order(title2, description2, price2);
            int expectedId = 2;
            Assert.AreEqual(expectedId, newOrder2.Id);
        }

        [TestMethod]
        public void GetAll_CanReturnListOfAll_ListOfOrders()
        {
            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);
            string title2 = "Order for Amy";
            string description2 = "Dozen cookies";
            int price2 = 20;
            Order newOrder2 = new Order(title2, description2, price2);

            List<Order> expectedValues = new List<Order> { newOrder, newOrder2 };
            CollectionAssert.AreEqual(expectedValues, Order.GetAll());
        }

        [TestMethod]
        public void Find_FindAnOrder_Order()
        {
            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);
            Order foundOrder = Order.Find(newOrder.Id);
            Assert.AreEqual(newOrder, foundOrder);
        }
    }
}