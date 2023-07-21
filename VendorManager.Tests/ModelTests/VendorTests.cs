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
    }
}