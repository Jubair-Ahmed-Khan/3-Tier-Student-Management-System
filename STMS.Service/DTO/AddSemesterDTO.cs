using STMS.Persistence.Models;

namespace STMS.Service.DTO
{
    //Add Semester DTO
    internal class AddSemesterDTO
    {
        public Semester? JoiningBatch { get; set; }
        public List<Course> AttendedCourse { get; set; }
        public List<Semester> SemestersAttended { get; set; }
    }
}
