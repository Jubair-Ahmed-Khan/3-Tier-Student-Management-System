using STMS.Persistence.Models;
using STMS.Service.DTO;

namespace STMS.Service.Mappers
{
    internal class ViewStudentMapper
    {
        public static ViewStudentDTO MapToDTO(Student student)
        {
            return new ViewStudentDTO
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department,
                Degree = student.Degree,
            };
        }
        public static Student MapToStudent(ViewStudentDTO student)
        {
            return new Student
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department,
                Degree = student.Degree,
            };
        }
    }
}
