using STMS.Persistence.Models;
using static STMS.Persistence.Models.Enums.Enums;

namespace STMS.Persistence.Contacts
{
    // Student Repository Interface
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(string studentId);
        void SaveStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        void AddSemesterAndCourses(string studentId, SemesterCode semesterCode, string year);
    }
}
