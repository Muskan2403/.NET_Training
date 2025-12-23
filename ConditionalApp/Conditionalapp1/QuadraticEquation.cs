//Quadratic Equation: Calculate roots of $ax^2 + bx + c = 0$ using if-else to check the discriminant.

using System;

namespace Conditionalapp1;

public class QuadraticEquation
{
    public static void QuadraticEquationMain()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        double root1 = -b + Math.Sqrt(discriminant) / 2 * a;
        double root2 = -b - Math.Sqrt(discriminant) / 2 * a;

        if(discriminant > 0)
        {
            
        }
        
    }
}
