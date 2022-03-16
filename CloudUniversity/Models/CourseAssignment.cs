using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudUniversity.Models
{
    public enum TestScore
    {
        A, B, C, D, F
    }
    public enum ExamScore
    {
        A, B, C, D, F
    }
    public enum CGPA
    {
        A, B, C, D, F
    }

    public class CourseAssignment
    {
        [Display(Name = "Enrollment ID")]
        //[ForeignKey("EnrollmentID")]
        public int? EnrollmentID { get; set; }
        public Enrollment Enrollment { get; set; }

        [Display(Name = "Test Score")]
     
        public TestScore? TestScore { get; set; }
        [Display(Name = "Exam Score")]
       
        public ExamScore? ExamScore { get; set; }
        [Display(Name = "Final Grade")]
       
        public CGPA? CGPA { get; set; }
        [StringLength(50)]
        [Display(Name = "Comments")]
        public string Location { get; set; }
        
       
    }
}