using System;

namespace Assignment3;

public class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }
    public int ProcessorCost {get; set; }

//Never make the fields(variable) public and variable are always in camel casing.
    public int RamPrice { get; } = 200;  //Read-Only Property
    public int HardDiskPrice { get; } =1500;
    public int GraphicCardPrice { get; } = 2500;
    
}
