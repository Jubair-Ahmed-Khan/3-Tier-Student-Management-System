using static STMS.Persistence.Models.Enums.Enums;

namespace STMS.Persistence.Models
{
    //Semester Model
    public class Semester
    {
        
        public SemesterCode SemesterCode { get; set; }
        public string? Year { get; set; }
        public List<Course> Courses { get; set; }

        public Semester() {
            Courses = new List<Course>();   
        }

        public Semester(SemesterCode semesterCode, string year)
        {
            SemesterCode = semesterCode;
            Year = year; 
            
        }
    }
}
