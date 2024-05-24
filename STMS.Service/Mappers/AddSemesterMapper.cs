using STMS.Persistence.Models;
using STMS.Service.DTO;

namespace STMS.Service.Mappers
{
    internal class AddSemesterMapper
    {
        public static AddSemesterDTO MapToDTO(Student student)
        {
            return new AddSemesterDTO
            {
                JoiningBatch = student.JoiningBatch,
                AttendedCourse = student.AttendedCourse,
                SemestersAttended = student.SemestersAttended,
            };
        }
    }
}
