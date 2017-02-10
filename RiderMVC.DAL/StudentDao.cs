using System;
using RiderMVC.Model;

namespace RiderMVC.DAL
{
    public class StudentDao
    {
        public int AddStudent(Student student)
        {
            using (var ctx = new SchoolContext())
            {
                try
                {
                    ctx.Students.Add(student);
                    ctx.SaveChanges();

                    return student.StudentID;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }
            }

        }
    }
}