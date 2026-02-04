using System;

namespace Q7DisplayHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = Convert.ToInt32(Console.ReadLine());

            if(height <= 0 || height > 300)
            {
                Console.WriteLine("Invalid height");
                return;
            }
            else{
                if(height  < 150)
                {
                    Console.WriteLine("Short");
                }
                else if(height >= 150 && height < 180)
                {
                    Console.WriteLine("Average");
                }
                else if(height >= 180)
                {
                    Console.WriteLine("Tall");
                }
            }
            
        }
    }
}