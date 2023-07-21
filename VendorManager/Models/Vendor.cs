using System.Collections.Generic;

namespace VendorManager.Models
{
    public class Vendor
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public static List<object> Orders = new List<object> { };
    }
}