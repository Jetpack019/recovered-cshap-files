using System;
using ECommerceApp;

namespace ECommerceConsoleApp {
    class Program {
        static void Main(string[] args) {
            ShoppingCart cart = new ShoppingCart();

            Product product1 = new Product { Name = "Smartphone", Price = 599.99M };
            Product product2 = new Product { Name = "Laptop", Price = 999.99M };

            cart.AddToCart(product1);
            cart.AddToCart(product2);

            Console.WriteLine("Shopping Cart Items:");
            foreach (Product item in cart.GetItems()) {
                Console.WriteLine(item);
            }

            decimal total = cart.CalculateTotal();
            Console.WriteLine($"Total: {total:C}");
        }
    }
}
