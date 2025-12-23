// See https://aka.ms/new-console-template for more information
using Day2DemoConsole;

static void Menu()
{
    System.Console.WriteLine("1. Add Student Details");
    System.Console.WriteLine("2. Display Student");
    System.Console.WriteLine("3. Exit");
} 

Student sObj = new Student(123,"Muskan","Mumbai");

sObj.DisplayDetails(sObj);

sObj = new Student(123, "Muskan", "Banglore");

sObj.DisplayDetails(sObj);

string[] cities = { "Mumbai", "Pune", "Banglore", "Chennai" };

// Iterate through the array using foreach loop. Only to print the data

foreach (string city in cities)
{
    System.Console.WriteLine(city);
}

// Iterate through the array using for loop. To print the data along with index

//switch case demo
int choice = 0;
do{
    Menu();
    System.Console.WriteLine("Enter your choice : ");
    choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1:
        System.Console.WriteLine("Case 1 executed");
        break;
    case 2:
        System.Console.WriteLine("Case 2 executed");
        break;
    default:
        System.Console.WriteLine("Default case executed");
        break;
}
}while(true);