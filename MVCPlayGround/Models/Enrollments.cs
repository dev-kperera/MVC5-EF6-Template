using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPlayGround.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }//PK
        public int CourseID { get; set; }//FK
        public int StudentID { get; set; }//FK
        public Grade? Grade { get; set; }//Grade Nullable 

        //1..1 navigation
        public virtual Course Course { get; set; }
        //1..1 navigation
        public virtual Student Student { get; set; }
    }

}
