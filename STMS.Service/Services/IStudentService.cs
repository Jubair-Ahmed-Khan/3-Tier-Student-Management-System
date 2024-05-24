using STMS.Persistence.Models;
using static STMS.Persistence.Models.Enums.Enums;

namespace STMS.Service.Services
{
    //Student Service Interface
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetById(string studentId);
        void AddStudent(string firstName, string middleName, string lastName, string studentId, Department department, Degree degree);
        void DeleteStudent(Student student);
        void AddSemesterAndCourses(string studentId, SemesterCode semesterCode, string year);
    }
}
