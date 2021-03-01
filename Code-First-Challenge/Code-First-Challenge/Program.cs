using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Challenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Maverick Johnson" };
                var grade = new Grade() { GradeName = "B" };



                ctx.Students.Add(student);
                ctx.Grades.Add(grade);
                ctx.SaveChanges();
            }
        }

    }
}