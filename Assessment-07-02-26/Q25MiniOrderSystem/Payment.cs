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

public class Payment
{
    public decimal Amount { get; private set; }
    public string Method { get; private set; }

    public Payment(decimal amount, string method)
    {
        Amount = amount;
        Method = method;
    }

    public void Process(decimal amount)
    {
        if (amount <= 0)
        {
            throw new Exceptions.PaymentFailedException("Invalid payment amount");
            
        }
        Console.WriteLine($"Payment of ₹{amount} successful");
    }
}
