using System;
using LPU_BL;
using LPU_Entity;
using LPU_Exceptions;
using System.Collections.Generic;

namespace LPU_UI
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("          Student Management System          ");
            Console.WriteLine("=============================================");
            Console.WriteLine("1. Search Student By ID");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Add Student Detail");
            Console.WriteLine("4. Update student Details");
            Console.WriteLine("5. Drop Student Details");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            StudentBL sblObj = null;
            sblObj = new StudentBL();
            do
            {
                Menu();

                int choice = 0;

                Console.Write("Please Enter your Choice: ");
                choice = Int32.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1: //Search Student by ID
                        {
                            int id = 0;
                            try
                            {
                                Console.Write("\tEnter Student ID for Search: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Student sObj = sblObj.SearchStudentByID(id);
                                if(sObj != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("======================================");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            catch(LpuException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 2: //Show All Students
                        {
                            try
                            {
                                Console.Write("\tEnter Student Name for Search: ");
                                string name = Console.ReadLine();

                                List<Student> studList = sblObj.SearchStudentByName(name);

                                if (studList != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("=============================================");

                                    foreach (var sObj in studList)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            catch(LpuException e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("We are Coming Soon.........");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("We are Coming Soon.........");
                                Console.ForegroundColor = ConsoleColor.White;

                            }


                            break;
                        }
                    case 3: //Add Student Detail
                        {
                            break;
                        }
                    case 4: //Update student Details
                        {
                            break;
                        }
                    case 5: //Drop Student Details
                        {
                            break;
                        }
                    case 6: //Exit
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }while (true);
        }

    }
}