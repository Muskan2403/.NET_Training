// See https://aka.ms/new-console-template for more information
using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Title:");
            string title = Console.ReadLine();

            System.Console.WriteLine("Enter the Author:");
            string author = Console.ReadLine();

            System.Console.WriteLine("Enter the Number of Pages:");
            int numPages = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the Due Date:");
            DateTime dueDate = Convert.ToDateTime(Console.ReadLine());

            System.Console.WriteLine("Enter the Return Date:");
            DateTime returnedDate = Convert.ToDateTime(Console.ReadLine());
            

            Book book = new Book(title, author, numPages, dueDate, returnedDate);

            System.Console.WriteLine("Enter the days to Read:");
            int daysToRead = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the daily Late Fee:");
            double dailyLateFeeRate = Convert.ToDouble(Console.ReadLine());

            double numberOfDaysLate = book.AveragePagesReadPerDay(daysToRead);

            double lateFee = book.CalculateLateFee(dailyLateFeeRate);

            Console.WriteLine($"Average Pages Read Per Day: {numberOfDaysLate}");

            Console.WriteLine($"Late Fee : {lateFee}");

            
        }
    }
}