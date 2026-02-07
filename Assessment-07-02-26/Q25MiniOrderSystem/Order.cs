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

public class Order
{
    public string InvoiceNumber { get; private set; }
    public List<OrderItem> Items { get; private set; }
    public decimal TotalAmount { get; set; }

    public Order(List<OrderItem> items)
    {
        Items = items;
        TotalAmount = CalculateTotal();
        InvoiceNumber = GenerateInvoiceNumber();
    }

    private decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var item in Items)
        {
            total += item.Product.Price * item.Quantity;
        }
        return total;
    }

    private string GenerateInvoiceNumber()
    {
        return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
    }

    public void AddToCart(Product product, int quantity)
    {
        Items.Add(new OrderItem(product, quantity));
    }

    public void PlaceOrder(Coupon coupon)
    {
        TotalAmount = CalculateTotal();

        foreach (var item in Items)
        {
            if (item.Quantity > item.Product.Stock)
                throw new InvalidOperationException($"Insufficient stock for {item.Product.Name}");
        }

        foreach (var item in Items)
        {
            item.Product.DeductStock(item.Quantity);
        }

        if (coupon != null && coupon.IsValid(TotalAmount))
        {
            TotalAmount = coupon.ApplyDiscount(TotalAmount);
        }
    }

}
