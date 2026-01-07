using System;
using System.Collections.Generic;
using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;

namespace LPU_DAL
{

    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;
        public StudentDAO()
        {
            studentList = new List<Student>{
                new Student(){StudentID = 101, Name="Alok",Course = CourseType.CSE,Address="Mumbai"},
                new Student(){StudentID = 102, Name="Riya",Course = CourseType.Mechanical,Address="Pune"},
                new Student(){StudentID = 103, Name="Priyam",Course = CourseType.CSE,Address="Kota"},
                new Student(){StudentID = 104, Name="Muskan",Course = CourseType.CSE,Address="Mumbai"},
                new Student(){StudentID = 105, Name="Priya",Course = CourseType.CSE,Address="Chennai"},
                new Student(){StudentID = 106, Name="Alok",Course = CourseType.CSE,Address="Kolkata"},
                new Student(){StudentID = 107, Name="Riya",Course = CourseType.Mechanical,Address="Jaipur"},
                new Student(){StudentID = 108, Name="Priyam",Course = CourseType.CSE,Address="Surat"},
                new Student(){StudentID = 109, Name="Muskan",Course = CourseType.CSE,Address="Sikar"},
                new Student(){StudentID = 110, Name="Priya",Course = CourseType.CSE,Address="Delhi"},
            };
        }

        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj != null)
            {
                studentList.Add(sObj);
                flag = true;
            }
            return flag;
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if (rollNo != 0)
            {
                myStud = studentList.Find(s => s.StudentID == rollNo);
                if (myStud == null)
                {
                    throw new LpuException("Student Record Not Found");
                }
            }
            else
            {
                throw new LpuException("Error Generated.......");
            }
            return myStud;
        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name == name);
            return data;
        }

        public bool UpdateStudentDetails(Student sObj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudentDetails(int id, Student sObj)
        {
            throw new NotImplementedException();
        }
    }
}