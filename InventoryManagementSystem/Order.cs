using System;
using System.Collections.Generic;

namespace InventoryManagementApp {
    public class Order {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public Order() {
            Products = new List<Product>();
            OrderDate = DateTime.Now;
        }

        public decimal CalculateTotal() {
            decimal total = 0;
            foreach (Product product in Products) {
                total += product.Price;
            }
            return total;
        }

        public override string ToString() {
            return $"Order ID: {OrderId}, Date: {OrderDate}, Total: {CalculateTotal():C}";
        }
    }
}
