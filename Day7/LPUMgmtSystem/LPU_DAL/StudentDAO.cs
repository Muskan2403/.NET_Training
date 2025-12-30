using System;
using System.Collections.Generic;
using LPU_Common;
using LPU_Entity;
using LPU_Exceptions

namespace LPU_DAL
{

    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;
        public StudentDAO()
        {
            studentList = {

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
    }
}