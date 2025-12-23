using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Person
    {
        //Fields

        public Person()
        {
            Console.WriteLine("Person Class Constructor invoked.");
        }

        ~Person()
        {
            Console.WriteLine("Person Class Destructor invoked.");
        }




    }
}
