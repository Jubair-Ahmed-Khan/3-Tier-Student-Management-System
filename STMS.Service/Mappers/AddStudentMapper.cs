using STMS.Persistence.Models;
using STMS.Service.DTO;

namespace STMS.Service.Mappers
{
    internal class AddStudentMapper
    {
        public static AddStudentDTO MapToDTO(Student student)
        {
            return new AddStudentDTO
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department,
                Degree = student.Degree,
            };
        }
        public static Student MapToStudent(AddStudentDTO addStudentDTO)
        {
            return new Student
            {
                FirstName = addStudentDTO.FirstName,
                MiddleName = addStudentDTO.MiddleName,
                LastName = addStudentDTO.LastName,
                StudentId = addStudentDTO.StudentId,
                Department = addStudentDTO.Department,
                Degree = addStudentDTO.Degree,

            };
        }
    }
}
