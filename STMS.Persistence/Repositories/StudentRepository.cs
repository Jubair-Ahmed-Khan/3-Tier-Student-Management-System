using Newtonsoft.Json;
using STMS.Persistence.Contacts;
using STMS.Persistence.Models;
using STMS.Persistence.Helpers;
using static STMS.Persistence.Models.Enums.Enums;

namespace STMS.Persistence.Repositories
{

    //Student Repository
    public class StudentRepository:IStudentRepository
    {
        private readonly string _filePath;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
        }

        //Get All Students from File
        public List<Student> GetAllStudents()
        {
            string jsonData = File.ReadAllText(_filePath);
            return JsonConverterMethod.FromJson<List<Student>>(jsonData) ?? new List<Student>();
        }

        //Get Student by ID from File
        public Student GetStudentById(string studentId)
        {
            List<Student> students = GetAllStudents();
            return students.FirstOrDefault(s => s.StudentId == studentId);
        }

        //Save Student to File
        public void SaveStudent(Student student)
        {
            List<Student> students = GetAllStudents();

            students.Add(student);

            string jsonData = JsonConverterMethod.ToJson(students);

            File.WriteAllText(_filePath, jsonData);
        }


        //Update Existing Student in the File
        public void UpdateStudent(Student student)
        {
            List<Student> students = GetAllStudents();

            int index = students.FindIndex(s => s.StudentId == student.StudentId);
            students[index] = student;

            string jsonData = JsonConverterMethod.ToJson(students);

            File.WriteAllText(_filePath, jsonData);
        }

        //Delete Student from File
        public void DeleteStudent(Student student)
        {
            List<Student> students = GetAllStudents();
            students.RemoveAll(s => s.StudentId == student.StudentId);

            string jsonData = JsonConverterMethod.ToJson(students);
            File.WriteAllText(_filePath, jsonData);
        }


        //Add Semester and Courses to Student
        public void AddSemesterAndCourses(string studentId, SemesterCode semesterCode, string year)
        {
            Student student = GetStudentById(studentId);

            if (student == null)
                throw new ArgumentException("Student not found with ID: " + studentId);

            Semester newSemester = new Semester(semesterCode, year);

            student.SemestersAttended.Add(newSemester);

            SaveStudent(student);
        }
    }
}
