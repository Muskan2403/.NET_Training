using System;

namespace Day2DemoConsole;

public class Student
{
    #region Fields
        int rollNo;
        string name;
        string addr;

    #endregion

/// <summary>
/// Default Constructor for student class
/// </summary>
    public Student()
    {
        rollNo = 100;
        name = "Dummy";
        addr = "Dummy City";
    }

/// <summary>
/// Parameterized Constructor for student class
/// </summary>
/// <param name="id"></param>
/// <param name="name"></param>
/// <param name="city"></param>
    public Student(int id, string name, string city)
    {
        rollNo = id;
        this.name = name;
        addr = city;
    }

    public void DisplayDetails(Student s1)
    {
        System.Console.WriteLine("Roll No :{0}\n Name : {1} \n Address : {2} ",s1.rollNo, s1.name, s1.addr);
    }

}
