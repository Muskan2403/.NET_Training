// See https://aka.ms/new-console-template for more information
using InterfaceDemo;

Console.WriteLine("Demo On Interfaces in C#");
IAdd m1 = new MathClass();

IAddSub m2 = new MathClass();

IAll m3 = new MathClass();


//Approach 1

Product p1 = new Product();
p1.ProdId = 101;
p1.Name = "Laptop";
p1.ProdPrice = 45000;

//Approach 2
//Object Initializer
Product p2 = new Product(){ ProdId = 102, Name = "Mobile", ProdPrice = 25000};

//Approach 3
//Collection Initializer

List<Product> prodList = new List<Product>()
{
    new Product(){ ProdId = 103, Name = "Tablet", ProdPrice = 15000},
    new Product(){ ProdId = 104, Name = "Smart Watch", ProdPrice = 8000},
    new Product(){ ProdId = 105, Name = "Headphones", ProdPrice = 3000},
    new Product(){ ProdId = 106, Name = "Speaker", ProdPrice = 2000},
    new Product(){ ProdId = 107, Name = "Monitor", ProdPrice = 12000}
};

foreach(var item in prodList)
{
    Console.WriteLine($"Product Id: {item.ProdId}, Name: {item.Name}, Price: {item.ProdPrice}");
}