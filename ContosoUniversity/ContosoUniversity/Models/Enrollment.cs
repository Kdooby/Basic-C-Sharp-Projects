using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } 
        public int CourseID { get; set; } // Foreign Key
        public int StudentID { get; set; } // Foreign Key
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }  // ? means this property is nullable

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
