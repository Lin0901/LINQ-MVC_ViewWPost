using Microsoft.AspNetCore.Mvc;
using ViewWPost.Models;

namespace ViewWPost.Controllers
{
    public class SchoolController : Controller
    {
        public SchoolController()
        {
            Student student1 = new Student("John","Cena");
            Student student2 = new Student("Randy","Orton");
            Student student3 = new Student("Jeff","Hardy");

            Course course1 = new Course("Chinese",6);
            Course course2 = new Course("Math",5);
            Course course3 = new Course("English",3);

            Registration reg1 = new Registration(student1, course2);
            student1.Registrations.Add(reg1);
            course2.Registrations.Add(reg1);

            Registration reg2 = new Registration(student2, course2);
            student2.Registrations.Add(reg2);
            course2.Registrations.Add(reg2);

            //Registration reg3 = new Registration(student3, course1);
            //student3.Registrations.Add(reg3);
            //course1.Registrations.Add(reg3);

            if(!Student.AllStudents.Any())
            {
                Student.AllStudents.Add(student1);
                Student.AllStudents.Add(student2);
                Student.AllStudents.Add(student3);
            }

            if(!Course.AllCourses.Any())
            {
                Course.AllCourses.Add(course1);
                Course.AllCourses.Add(course2);
                Course.AllCourses.Add(course3);
            }

            if(!Registration.AllRegistrations.Any())
            {
                Registration.AllRegistrations.Add(reg1);
                Registration.AllRegistrations.Add(reg2);
            //    Registration.AllRegistrations.Add(reg3);
            }
        }
        
        public IActionResult Index()
        {
            if(Course.AllCourses == null)
            {
                return BadRequest();
            }
            return View(Course.AllCourses);
        }

        public IActionResult StudentDetails(int? studentId)
        {
            Student foundStudent;

            if (studentId == null)
            {
                return NotFound();
            }
            else
            {
                foundStudent = Student.AllStudents.FirstOrDefault(s => s.Id == studentId);
            }
            

            if(foundStudent == null)
            {
                return NotFound();
            }
            else
            {
                return View(foundStudent);
            }
        }
        public IActionResult CourseDetails(int? courseId)
        {
            Course foundCourse;
            if (courseId == null)
            {
                return NotFound();
            }
            else
            {
                foundCourse = Course.AllCourses.FirstOrDefault(c => c.Id == courseId);
            }

            if( foundCourse == null)
            {
                return NotFound();
            }
            else
            {
                return View(foundCourse);
            }
        }
    }
}

