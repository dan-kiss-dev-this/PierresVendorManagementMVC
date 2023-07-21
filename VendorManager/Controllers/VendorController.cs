using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorManager.Models;

namespace VendorManager.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/vendors")]
        public ActionResult Vendors()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Vendors");
        }

        [HttpGet("/vendors/{vendorId}")]
        public ActionResult Show(int vendorId)
        {
            Vendor foundVendor = Vendor.Find(vendorId);
            return View(foundVendor);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderName, string orderDescription, int orderPrice)
        {
            Vendor foundVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderName, orderDescription, orderPrice);
            foundVendor.AddOrder(newOrder);
            return View("Show", foundVendor);
        }
    }
}