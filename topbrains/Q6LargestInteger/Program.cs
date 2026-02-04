using System;
namespace Q6LargestInteger
{
    class Program{
        public static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine($"{num1} is the Largest Integer");
                }
                else
                {
                    Console.WriteLine($"{num3} is the Largest Integer");

                }
            }
            else
            {
                if(num2 > num3)
                {
                    Console.WriteLine($"{num2} is the Largest Integer");
                }
                else
                {
                    Console.WriteLine($"{num3} is the Largest Integer");
                }
            }


        }
    }
}