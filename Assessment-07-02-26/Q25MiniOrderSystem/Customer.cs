using System;

namespace MiniOrderSystem;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; private set; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
