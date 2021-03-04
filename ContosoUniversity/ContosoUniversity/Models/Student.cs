using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }//The Enrollments property is a navigation property. 
                                                                        //Navigation properties hold other entities that are related to this entity. 
                                                                        //In this case, the Enrollments property of a Student entity will hold all of the Enrollment entities that are related to that Student entity.
    }
}

