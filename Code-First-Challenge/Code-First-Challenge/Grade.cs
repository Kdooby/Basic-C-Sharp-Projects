using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Challenge
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; } // ICollection represents a type of collection. 
                                                           // Specifying a collection as an ICollection allows you to use any type of collection in your code that implements the ICollection interface
    }
}