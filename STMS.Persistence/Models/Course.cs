namespace STMS.Persistence.Models
{
    //Course Model
    public class Course
    {
        public string CourseId { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string InstructorName { get; set; } = string.Empty;
        public double NumberOfCredits { get; set; }

        public Course(string courseID, string courseName, string instructorName, double credits)
        {
            CourseId = courseID;
            CourseName = courseName;
            InstructorName = instructorName;
            NumberOfCredits = credits;
        }
    }
}
