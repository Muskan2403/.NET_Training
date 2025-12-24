// See https://aka.ms/new-console-template for more information

using System;
using Assignment4;

class Program
{
    public static Candy CalculateDiscountedPrice(Candy candy)
    {
        switch (candy.Flavour)
        {
            case "Strawberry":
                {
                    candy.DiscountPercentage = 15;
                    break;
                }
            case "Lemon":
                {
                    candy.DiscountPercentage = 10;
                    break;
                }
            case "Mint":
                {
                    candy.DiscountPercentage = 5;
                    break;
                }
            
        }
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

        candy.Discount = candy.TotalPrice - (candy.TotalPrice * candy.DiscountPercentage / 100);
        
        return candy;
    }
    public static void Main(string[] args)
    {
        Candy candy1 = new Candy();

        Console.WriteLine("Enter Candy Flavour:");
        candy1.Flavour = Console.ReadLine();

        if(candy1.ValidateCandyFlavour()){
            Console.WriteLine("Enter the  Quantity:");
            candy1.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price per piece:");
            candy1.PricePerPiece = Convert.ToInt32(Console.ReadLine());

            candy1 = CalculateDiscountedPrice(candy1);

            Console.WriteLine($"Flavour: {candy1.Flavour}");
            Console.WriteLine($"Quantity: {candy1.Quantity}");
            Console.WriteLine($"Price per piece: {candy1.PricePerPiece}");
            Console.WriteLine($"Total Price: {candy1.TotalPrice}");
            Console.WriteLine($"Discount: {candy1.Discount}");
        }
        else
        {
            Console.WriteLine("Invalid Flavour");
            
        }
    }
    
}
