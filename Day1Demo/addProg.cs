using System;

class AddProgram
{
    static void Main()
    {
        int num1 = 100;
        int num2 = 200;
        int numResult;

        //take input below
        Console.Write("Enter first number: ");
        num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = Int32.Parse(Console.ReadLine());

        //BL
        int disc = (num1+num2)*10/100;
        numResult = (num1 + num2) - disc;  //Payable by the customer

        //Print
        //Console.Write("The sum of {0} and {1} is {2}", num1, num2, numResult);

        //Console.ReadLine();

        Console.WriteLine("LPU shopee");
        Console.WriteLine("Price of product 1 {0}", num1);
        Console.WriteLine("Price of product 2 {0}", num2);
        Console.WriteLine("Total price {0}", num1 + num2);
        Console.WriteLine("Discount {0}", disc);
        Console.WriteLine("Amount payable after discount: {0}", numResult);

    }
}