using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MVCPlayGround.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }//PK
        public string Title { get; set; }
        public int Credits { get; set; }

        //1 to many navigation
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
