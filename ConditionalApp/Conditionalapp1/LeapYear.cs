//Leap Year Checker: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).

using System;

namespace Conditionalapp1;

public class LeapYear
{
    public static void LeapYearMain()
    {
        int year = Convert.ToInt32(Console.ReadLine());

        if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            System.Console.WriteLine("{0} ia a Leap Year", year);
        }
        else
        {
            System.Console.WriteLine("{0} is not a Leap Year", year);
        }
    }
}
