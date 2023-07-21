using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace VendorManager.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}