using System;

namespace Q25MidpointRounding
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaOfCircle = Area(radius);

            Console.WriteLine($"Area is {areaOfCircle} cm²");
        }

        public static double Area(double radius)
        {
            double area = Math.PI * radius * radius;
            double result = Math.Round(area, 2, MidpointRounding.AwayFromZero);

            return result;
        }
    }
}