using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Challenge
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; } // "?" means DateTime is Nullable
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }

    }
}
