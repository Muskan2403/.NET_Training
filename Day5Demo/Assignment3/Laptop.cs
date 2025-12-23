using System;
using System.Reflection;

namespace Assignment3;

public class Laptop : Computer
{
    public int DiplaySize { get; set; }

    public int BatteryVoult { get; set; }

    public int DisplayPrice{get;} = 250;
    public int BatteryPrice{get;} = 20;

    // public Laptop()
    // {
    //     //No logic to be written in constructor.
    // }

    public double LaptopPriceCalculation()
    {
        switch (Processor)
        {
            case "i3":
            {
                ProcessorCost = 2500;
                break;
            }
            case "i5":
            {
                ProcessorCost = 5000;
                break;
            }
            case "i7":
            {
                ProcessorCost = 6500;
                break;
            }
            default:
            {
                ProcessorCost = 0;
                break;
            }
        }
        double LaptopPrice = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + 
        (GraphicCard * GraphicCardPrice) + (DiplaySize * DisplayPrice) + (BatteryVoult * BatteryPrice);

        return LaptopPrice;
    }

}
