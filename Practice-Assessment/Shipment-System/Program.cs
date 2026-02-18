using System;

namespace Shipment_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShipmentDetails ship = new ShipmentDetails();

            Console.Write("Input Id: ");
            ship.ShipmentCode = Console.ReadLine();

            bool validate = ship.ValidateShipmentCode();

            if (validate)
            {
                Console.Write("Mode: ");
                ship.TransportMode = Console.ReadLine();

                Console.Write("Weight: ");
                ship.Weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Storage: ");
                ship.StorageDays = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The total shipping cost is {ship.CalculateTotalCost():F2}");

            }
            else
            {
                Console.WriteLine("Invalid shipment code");
            }

        }
    }
}