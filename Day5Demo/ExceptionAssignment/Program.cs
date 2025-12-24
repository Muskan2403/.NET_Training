// See https://aka.ms/new-console-template for more information

using System;
using ExceptionAssignment;

class Program{

    static void Main(string[] args){

        Cake cake = new Cake();

        Console.WriteLine("Enter the flavour:");
        cake.Flavour = Console.ReadLine();
        Console.WriteLine("Enter the quantity in kg:");
        cake.QuantityInKg = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price per kg:");
        cake.PricePerKg = Convert.ToDouble(Console.ReadLine());
        try
        {
            bool orderStatus = cake.CakeOrder();
            if (orderStatus)
            {
                double finalPrice = cake.CalculatePrice();
                Console.WriteLine("Cake order was successfully.");
                Console.WriteLine($"Price after discount is: {finalPrice}");
            }
        }
        catch (InvalidFlavourException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidQuantityException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}