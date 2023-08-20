using System;

namespace InventoryManagementApp {
    public class Product {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public override string ToString() {
            return $"{Name} - Price: {Price:C}, Stock: {StockQuantity}";
        }
    }
}
