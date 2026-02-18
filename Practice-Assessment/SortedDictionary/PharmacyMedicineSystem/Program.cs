using System;

namespace PharmacyMedicineSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            MedicineUtility medUtility = new MedicineUtility();

            Console.WriteLine("1. Display all medicines(sorted by expiry year): ");
            Console.WriteLine("2. Update Medicine Price");
            Console.WriteLine("3. Add Medicine");
            Console.WriteLine("4. Exit");

            while(true){
                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        medUtility.GetAllMedicine();
                        break;
                    case 2:
                        Console.Write("Enter Medicine Id and New Price for updation: ");
                        string[] entry = Console.ReadLine().Split(" ");

                        medUtility.UpdateMedicinePrice(entry[0], int.Parse(entry[1]));
                        Console.WriteLine("Updated Succesfully.");

                        break;

                    case 3:
                        Console.Write("Enter Medicine Id, Name, Price and Expirt Year: ");

                        string[] ip = Console.ReadLine().Split(" ");

                        Medicine med = new Medicine
                        {
                            Id = ip[0],
                            Name = ip[1],
                            Price = Convert.ToInt32(ip[2]),
                            ExpiryYear = Convert.ToInt32(ip[3])
                        };

                        medUtility.AddMedicine(med);
                        Console.WriteLine("Medicine Added Successfully.");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            
        }
    }
}
