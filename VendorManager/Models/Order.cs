using System.Collections.Generic;
using System;

namespace VendorManager.Models
{
    public class Order
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public DateTime Date { get; }

        public int Id { get; }

        public static List<Order> _instances = new List<Order> { };

        public Order(string title, string description, int price)
        {
            Title = title;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            Price = price;
            Date = DateTime.Now;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static Order Find(int id)
        {
            Order foundVendor = Order._instances[id - 1];
            return foundVendor;
        }
    }
}