// See https://aka.ms/new-console-template for more information
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            CabDetails cab = new CabDetails();

            System.Console.WriteLine("Enter the Booking ID:");
            cab.BookingID = Console.ReadLine();


            if (cab.ValidateBookingID())
            {
                System.Console.WriteLine("Enter the Cab Type: ");
                cab.CabType = Console.ReadLine();

                System.Console.WriteLine("Enter the distance in Km:");
                cab.Distance = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Enter the Waiting Time in Minutes:");
                cab.WaitingTime = Convert.ToInt32(Console.ReadLine());


                double fare = cab.CalculateFareAmount();

                System.Console.WriteLine($"The Fare Amount is {fare}");
            }
            else
            {
                System.Console.WriteLine("Invalid Booking ID");
            }
            


            
            
        }
    }
}
