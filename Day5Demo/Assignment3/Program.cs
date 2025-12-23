// See https://aka.ms/new-console-template for more information
using System;
using Assignment3;

int choice;
Console.WriteLine("Choose the option:");
Console.WriteLine("1. Desktop");
Console.WriteLine("2. Laptop");
choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
    {
        Desktop desktop = new Desktop();

        Console.WriteLine("Enter the Processor: ");
        desktop.Processor = Console.ReadLine();

        Console.WriteLine("Enter the Ram Size: ");
        desktop.RamSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Hard Disk Size: ");
        desktop.HardDiskSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Graphic Card: ");
        desktop.GraphicCard = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Monitor Size: ");
        desktop.MonitorSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Power Supply Voult: ");
        desktop.PowerSupplyVoult = Convert.ToInt32(Console.ReadLine());

        double desktopPrice = desktop.DesktopPriceCalculation();
        Console.WriteLine("Desktop Price is: " + desktopPrice);

        break;
    }

    case 2:
    {
        Laptop laptop = new Laptop();

        Console.WriteLine("Enter the Processor: ");
        laptop.Processor = Console.ReadLine();

        Console.WriteLine("Enter the Ram Size: ");
        laptop.RamSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Hard Disk Size: ");
        laptop.HardDiskSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Graphic Card: ");
        laptop.GraphicCard = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Display Size: ");
        laptop.DiplaySize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Battery Voult: ");
        laptop.BatteryVoult = Convert.ToInt32(Console.ReadLine());

        double laptopPrice = laptop.LaptopPriceCalculation();
        Console.WriteLine("The Laptop Price is: " + laptopPrice);

        break;
    }

    default:
    {
    
        Console.WriteLine("Invalid Choice");
        break;
    }

}
