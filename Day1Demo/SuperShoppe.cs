using System;
using MyRetailLogic;

class AddProgram
{
    static void Main()
    {
        int prod1 = 100;
        int prod2 = 200;
        int numResult;

        //take input below
        Console.Write("Enter first number: ");
        prod1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        prod2 = Int32.Parse(Console.ReadLine());

        //BL
        RetailLogic rlObj = new RetailLogic();
        int disc = CalcDiscount(prod1+prod2);
        numResult = (prod1+prod2) - disc;  //Payable by the customer

        //Print
        //Console.Write("The sum of {0} and {1} is {2}", num1, num2, numResult);

        //Console.ReadLine();

        Console.WriteLine("LPU shopee");
        Console.WriteLine("Price of product 1 {0}", prod1);
        Console.WriteLine("Price of product 2 {0}", prod2);
        Console.WriteLine("Total price {0}", prod1+prod2);
        Console.WriteLine("Discount {0}", disc);
        Console.WriteLine("Amount payable after discount: {0}", numResult);

    }
}