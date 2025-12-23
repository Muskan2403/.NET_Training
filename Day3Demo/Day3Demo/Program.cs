// See https://aka.ms/new-console-template for more information

using Day3Demo;

internal class Program
{
    static void SwapMe(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine("Inside Swap Func\nvalue for Num1 : {0} and Num2 : {1}",x,y);
    }

    //Method overloading. It happens when the tpye of parameters or the number of parameters change.
    public int AddToCart(params int[] prices) //params [] is used when many values are given
    {
        int total = 0;
        foreach(int i in prices)
        {
            total += i;
        }
        return total;
    }

    public int AddToCart(int p1, int p2)
    {
        return p1+p2;
    }

    public int AddToCart(int p1, int p2, int p3)
    {
        return p1+p2+p3;
    }
    static void Main(string[] args)
    {
        Person p1 = new Person();
        //Employee employee = null;   every time write like this for child class when not in use.
        //employee = new Employee();

        //p1.Display();

        //Casting Demo Below
        //Casting word is used when value to value & ref to ref 
        int x = 100;

        long z = x;   // Implicit Cast

        short y = (short) x;  //Explicit Casting


        //Boxing & Unboxing is used when value to ref & ref to value

        int num1 = 120;
        object op = num1; //Boxing (Value to ref)

        int num2 = (int) op;  //UnBoxing (ref to value)

        //int no1 = 100;
        //int no2 = 200;

        //Console.WriteLine("Prior Swap Func\nvalue for Num1 : {0} and Num2 : {1}", no1, no2);
        //SwapMe(no1, no2);

        Program pObj = new Program();
        //pObj.AddToCart(5);
        pObj.AddToCart(10,20);
        pObj.AddToCart(10,20,30,40,50);


    }
}