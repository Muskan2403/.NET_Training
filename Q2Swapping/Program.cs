using System;

namespace Q2Swapping{
    class Program
    {
        // Method 1: Swap using ref
        static void SwapUsingRef(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        // Method 2: Swap using out
        static void SwapUsingOut(int a, int b, out int x, out int y)
        {
            x = a + b;
            y = x - b;
            x = x - y;
        }

        static void Main()
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("---Swap Using Ref---");

            Console.WriteLine("Before Swap: x = " + x + ", y = " + y);
            SwapUsingRef(ref x, ref y);
            Console.WriteLine("After Swap:  x = " + x + ", y = " + y);

            int a = 30;
            int b = 40;
            int p, q;

            Console.WriteLine("\n---Swap Using Out---");

            Console.WriteLine("Before Swap: a = " + a + ", b = " + b);
            SwapUsingOut(a, b, out p, out q);
            Console.WriteLine("After Swap:  a = " + p + ", b = " + q);
        }
    }
}