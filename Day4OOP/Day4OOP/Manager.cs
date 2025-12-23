using System;
using System.Collections.Generic;
using System.Text;

namespace Day4OOP
{
    internal class Manager : Employee
    {
        public int MgrID { get; set; }
        public int Incentive { get; set; }

        //function override 
        public override int CalcSalary(int sal)
        {
            int mySal = 0;
            //NetSalary = Salary+hra+ta+da-pf
            mySal = (sal + 35000 + 12000 + 4500 - 8500);
            return mySal;
        }
    }
}
