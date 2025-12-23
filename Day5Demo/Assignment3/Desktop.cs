using System;

namespace Assignment3;

public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVoult { get; set; }
    public int MonitorPrice { get; } = 250;
    public int PowerSupplyPrice{ get; } = 20;
    
    public double DesktopPriceCalculation()
    {
        switch (Processor)
        {
            case "i3":
            {
                ProcessorCost = 1500;
                break;
            }
            case "i5":
            {
                ProcessorCost = 3000;
                break;
            }
            case "i7":
            {
                ProcessorCost = 4500;
                break;
            }
            default:
            {
                ProcessorCost = 0;
                break;
            }
        }
        double DesktopPrice = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) +
        (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + (PowerSupplyVoult * PowerSupplyPrice);

        return DesktopPrice;
    }
}
