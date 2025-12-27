// See https://aka.ms/new-console-template for more information
using System;

namespace QuickMartTraders{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while(true){

            Console.WriteLine("==================Quick Mart Traders==================");
            Console.WriteLine("1. Create New Transaction(Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction ");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print) ");
            Console.WriteLine("4. Exit");

            Console.Write($"Enter Your Option: ");
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    SaleTransaction.CreateNewTransaction();
                    break;

                case 2:
                    SaleTransaction.ViewLastTransaction();
                    break;

                case 3:
                    SaleTransaction.RecomputeAndPrintLastTransaction();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        }
    }
}