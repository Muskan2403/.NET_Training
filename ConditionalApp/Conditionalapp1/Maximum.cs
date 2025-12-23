//Largest of Three: Take three integers and find the maximum using nested if.

using System;

namespace Conditionalapp1;
public class Maximum
{
    public static void MaximumMain()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2)  // checking if num1 is greater than num2
        {
            if(num1 > num3) //num3 is greater than num1 
            {
                System.Console.WriteLine("Maximum is: {0}", num1);
            }
            else
            {
                System.Console.WriteLine("Maximum is: {0}", num3);
            }
        }
        else
        {
            if(num2 > num3)
            {
                System.Console.WriteLine("Maximum is: {0}", num2);
            }
            else
            {
                System.Console.WriteLine("Maximum is: {0}", num3);
            }
        }
    }
}
