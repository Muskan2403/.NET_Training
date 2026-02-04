using System;

namespace Q19Conversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Feet: ");
            int feet = Convert.ToInt32(Console.ReadLine());

            double centimeters = FeetToCentimeter(feet);
            

            Console.WriteLine($"{feet} Feet = {centimeters}cm");
        }

        public static double FeetToCentimeter(int feet)
        {
            double centimeter = feet * 30.48;
            double result = Math.Round(centimeter,2,MidpointRounding.AwayFromZero);

            return result;
        }
    }
}