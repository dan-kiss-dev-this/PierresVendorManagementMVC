using System.Collections.Generic;

namespace VendorManager.Models
{
    public class Vendor
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Id { get; }

        public List<Order> Orders = new List<Order> { };

        public static List<Vendor> _instances = new List<Vendor> { };

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public void AddOrder(Order newOrder)
        {
            Orders.Add(newOrder);
        }

        public static Vendor Find(int id)
        {
            Vendor foundVendor = Vendor._instances[id - 1];
            return foundVendor;
        }
    }
}