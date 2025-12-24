// See https://aka.ms/new-console-template for more information

using System;
using Assignment4;

class Program
{
    public Candy CalculateDiscountedPrice(Candy candy)
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
            default:
                {
                    candy.DiscountPercentage = 0;
                    break;
                }
            
        }
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

        candy.Discount = candy.TotalPrice - (candy.TotalPrice * candy.DiscountPercentage / 100);
        
        return candy;
    }
    public static void Main(string[] args)
    {
        Candy candy = new Candy();

        Console.WriteLine("Enter Candy Flavour:");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the  Quantity:");
        candy.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Price per piece:");
        candy.PricePerPiece = Convert.ToInt32(Console.ReadLine());

        if(candy.ValidateCandyFlavour()){
            

            Program program = new Program();
            candy = program.CalculateDiscountedPrice(candy);

            Console.WriteLine($"Flavour: {candy.Flavour}");
            Console.WriteLine($"Quantity: {candy.Quantity}");
            Console.WriteLine($"Price per piece: {candy.PricePerPiece}");
            Console.WriteLine($"Total Price: {candy.TotalPrice}");
            Console.WriteLine($"Discount: {candy.Discount}");
        }
        else
        {
            Console.WriteLine("Invalid Flavour");
        }
    }
    
}
