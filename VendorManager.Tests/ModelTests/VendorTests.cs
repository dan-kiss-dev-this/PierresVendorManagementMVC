using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorManager.Models;
using System.Collections.Generic;
using System;

namespace VendorManager.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Pepsi", "Beverage Manufacturer");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_CanReturnName_String()
        {
            string vendorName = "Pepsi";
            string vendorDescription = "Beverage Manufacturer";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            Assert.AreEqual(vendorName, newVendor.Name);
        }

        [TestMethod]
        public void GetDescription_CanReturnDescription_String()
        {
            string vendorName = "Pepsi";
            string vendorDescription = "Beverage Manufacturer";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            Assert.AreEqual(vendorDescription, newVendor.Description);
        }

        [TestMethod]
        public void GetId_CanReturnId_Int()
        {
            string vendorName = "Pepsi";
            string vendorDescription = "Beverage Manufacturer";
            string vendorName2 = "Whole Foods";
            string vendorDescription2 = "Specialty grocery chain";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
            int expectedId = 2;
            Assert.AreEqual(expectedId, newVendor2.Id);
        }

        [TestMethod]
        public void GetAll_CanReturnListOfAll_ListOfVendors()
        {
            string vendorName = "Pepsi";
            string vendorDescription = "Beverage Manufacturer";
            string vendorName2 = "Whole Foods";
            string vendorDescription2 = "Specialty grocery chain";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
            List<Vendor> expectedValues = new List<Vendor> { newVendor, newVendor2 };
            CollectionAssert.AreEqual(expectedValues, Vendor.GetAll());
        }

        [TestMethod]
        public void AddOrder_AddAnOrderToAVendor_ListOfOrders()
        {
            //arrange
            string vendorName = "Pepsi";
            string vendorDescription = "Beverage Manufacturer";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);

            string title = "Order for Amy";
            string description = "Dozen cookies";
            int price = 10;
            Order newOrder = new Order(title, description, price);

            //act
            newVendor.AddOrder(newOrder);

            //assert
            List<Order> expectedValues = new List<Order> { newOrder };
            CollectionAssert.AreEqual(expectedValues, newVendor.Orders);
        }
    }
}