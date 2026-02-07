using System;

namespace MiniOrderSystem;

public class Coupon
{
    public string Code { get; private set; }
    public decimal DiscountAmount { get; private set; }
    public DateTime ExpiryDate { get; private set; }

    public Coupon(string code, decimal discountAmount, DateTime expiryDate)
    {
        Code = code;
        DiscountAmount = discountAmount;
        ExpiryDate = expiryDate;
    }

    public bool IsValid(decimal totalAmount)
    {
        return DateTime.Now < ExpiryDate;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        if (!IsValid(totalAmount))
            throw new InvalidOperationException("Coupon is expired.");
        return totalAmount - DiscountAmount;
    }
}
