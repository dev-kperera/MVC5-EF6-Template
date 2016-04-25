using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPlayGround.Models
{
    class Models
    {
        //TODO:[2] Define your model classes

        //Define properties 
        //public int MyProperty { get; set; }
        //ID at the as the end of property define as PK (Eg. classnameID)
        //If property doesnot follow classnameID characteristic, Need to annotate with [key]

        //FK
        //PKs in other model classes define as FKs
        //Or need to explicity define as below

        //[Key]
        //[ForeignKey("Instructor")] //to which class it it refers to
        //public int InstructorID { get; set; } 


        //Define Navgations
        //(Navigation always concerns in the working model point of view)
        //
        ///One to Many(In student model class)
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
        ///
        //One to One (In Enrollment class)
        ////public virtual Student Student { get; set; }


        ///
        //Validations and annotations
                //[DataType(DataType.Date)]
                //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
                
                //[Required]
                //[StringLength(50)]
                //StringLength(50, MinimumLength=1)]
                //[Display(Name = "Last Name")]

                //[DataType(DataType.Currency)]
                //[Column(TypeName = "money")]


                //Eliminate DB creating keys
                //[DatabaseGenerated(DatabaseGeneratedOption.None)]



                
    }
}