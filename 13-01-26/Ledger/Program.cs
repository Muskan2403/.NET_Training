using System;

namespace Ledger
{
    class Program
    {
        static void Main(string[] args)
        {
            Khata khata = new Khata(new Dictionary<string, int>()
            {
                { "Milk", 100 },
                { "Tea", 50 },
                { "Coffee", 100 },
                { "Sugar", 50 },
                { "Salt", 200 }
            });
            
            Console.WriteLine("Total Amount: " + khata.getTotal());
            Console.WriteLine("Repeated Amount: " + khata.getRepeatAmount());

        }
    }
}