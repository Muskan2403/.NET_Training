// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using MediSureClinic;

namespace QuickMartTraders{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while(true){

            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill ");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");

            Console.Write($"Enter Your Option: ");
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    PatientBill.CreateNewBill();
                    break;

                case 2:
                    PatientBill.ViewLastBill();
                    break;

                case 3:
                    PatientBill.ClearLastBill();
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