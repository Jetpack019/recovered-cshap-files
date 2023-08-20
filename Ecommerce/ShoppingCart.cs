using System.Collections.Generic;

namespace ECommerceApp {
    public class ShoppingCart {
        private List<Product> items;

        public ShoppingCart() {
            items = new List<Product>();
        }

        public void AddToCart(Product product) {
            items.Add(product);
        }

        public List<Product> GetItems() {
            return items;
        }

        public decimal CalculateTotal() {
            decimal total = 0;
            foreach (Product product in items) {
                total += product.Price;
            }
            return total;
        }
    }
}
