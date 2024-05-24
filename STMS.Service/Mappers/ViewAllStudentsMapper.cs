using STMS.Persistence.Models;
using STMS.Service.DTO;

namespace STMS.Service.Mappers
{
    internal class ViewAllStudentsMapper
    {
        public static ViewAllStudentsDTO MapToDTO(Student student)
        {
            return new ViewAllStudentsDTO
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                JoiningBatch = student.JoiningBatch,
                Department=student.Department,
                Degree=student.Degree,   
            };
        }
    }
}
