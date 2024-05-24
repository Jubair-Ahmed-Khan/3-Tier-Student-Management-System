using STMS.Persistence.Models;
using STMS.Persistence.Repositories;
using STMS.Presentation.Controllers;
using STMS.Presentation.CustomAttributes;
using STMS.Service.Services;

namespace STMS.Presentation
{
    //Custom Attribute
    [Developer("Jubair Ahmed Khan")]
    public class Program
    {
        static void Main(string[] args)
        {
            var attributes = Attribute.GetCustomAttributes(typeof(Program));

            var developerAttribute = attributes.OfType<DeveloperAttribute>().Single();

            Console.WriteLine(developerAttribute.GetName());


            Course[] courses = CreateCourses();

            string studentDataPath = "students.json";

            StudentRepository studentRepository = new StudentRepository(studentDataPath);

            StudentService studentService = new StudentService(studentRepository, courses);

            StudentController studentController = new StudentController(studentService);

            StudentMenu menu = new StudentMenu(studentController);

            while (true)
            {
               menu.DisplayMenu();
            } 

        }
        private static Course[] CreateCourses()
        {
            Course[] courses = new Course[]
            {
                new Course ( "CSE 101", "C Programming", "Prof. Nasir", 3.5),
                new Course ("CSE 102","Machine Learning","Prof. Motiur", 2.5),
                new Course ("CSE 103", "Java Programming", "Prof. Misbah", 3.5),
                new Course ("CSE 104", "Arcitecture", "Prof. Sultan", 2.5),
                new Course ("CSE 105", "Mathematics I", "Prof. Musa" ,3.0)
            };

            return courses;
        }
    }
}
