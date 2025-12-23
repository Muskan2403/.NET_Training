using System;
using System.Collections.Generic;
using System.Text;

namespace Day4OOP
{
    internal class Employee
    {
        #region Properties
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int BasicSal { get; set; }

        #endregion

        public virtual int CalcSalary(int sal)
        {
            int mySal = 0;
            //NetSalary = Salary+hra+ta+da-pf
            mySal = (sal + 15000+3000+1500-2500);
            return mySal;
        }

    }
}
