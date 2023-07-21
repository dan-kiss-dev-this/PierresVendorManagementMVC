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
    }
}