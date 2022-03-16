using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudUniversity.Models
{
 

    public class Enrollment
    {
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("StudentID")]
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
        //[DisplayFormat(NullDisplayText = "No grade")]

        public Course Course { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

    }
}
