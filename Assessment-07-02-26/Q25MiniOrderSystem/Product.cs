/*Design a mini order system with entities: Customer, Product, Order, OrderItem, Payment.
Implement:
• Add to cart
• Place order (validate stock)
• Deduct stock atomically
• Apply coupon with rules
• Generate invoice number
• Handle failures with meaningful exceptions.
*/

using System;

namespace MiniOrderSystem{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public Product(int id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void DeductStock(int quantity)
        {
            if (quantity > Stock)
                throw new InvalidOperationException("Insufficient stock.");
            Stock -= quantity;
        }

    }
}