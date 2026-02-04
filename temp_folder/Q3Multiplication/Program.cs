using System;

namespace Q3Multiplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int upto = Convert.ToInt32(Console.ReadLine());

            int[] row = new int[upto];

            for (int i = 0; i < upto; i++)
            {
                row[i] = n * (i + 1);

            }
            Console.Write("[");

            for(int i = 0;i< upto; i++)
            {
                Console.Write(row[i]);
                if (i < upto - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }
    }
}