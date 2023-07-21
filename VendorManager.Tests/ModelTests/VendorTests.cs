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
            //clear the list
        }

        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor();
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        public void GetName_CanReturnName_Name()
        {
            
        }
    }
}