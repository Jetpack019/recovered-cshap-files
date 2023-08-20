using System;
using System.Collections.Generic;

namespace InventoryManagementApp {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();

            Product product1 = new Product { ProductId = 1, Name = "Laptop", Price = 999.99M, StockQuantity = 10 };
            Product product2 = new Product { ProductId = 2, Name = "Smartphone", Price = 599.99M, StockQuantity = 20 };

            products.Add(product1);
            products.Add(product2);

            Order order1 = new Order();
            order1.Products.Add(product1);
            order1.Products.Add(product2);

            Order order2 = new Order();
            order2.Products.Add(product1);

            Console.WriteLine("Inventory Management System:");
            foreach (Product product in products) {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nOrders:");
            Console.WriteLine(order1);
            Console.WriteLine(order2);
        }
    }
}
