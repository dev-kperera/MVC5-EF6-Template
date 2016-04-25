using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPlayGround.Models
{
    public class Student
    {
         public int ID { get; set; } //PK
        public string LastName { get; set; } 

        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation property (1 to many)
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}