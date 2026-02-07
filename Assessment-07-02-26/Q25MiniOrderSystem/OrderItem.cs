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

namespace MiniOrderSystem;

public class OrderItem
{
    public Product Product { get; private set; }
    public int Quantity { get; private set; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}
