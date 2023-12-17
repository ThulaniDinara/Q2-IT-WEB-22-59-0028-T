using Microsoft.AspNetCore.Mvc;
using StudentWebApplication.Model;
 

namespace StudentWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentInformation()
        {
            var studentsData = new List<StudentDetail>
            {
                new StudentDetail { StudentID = 1, StudentName = "Kasun Gamage", City = "Kandy", CourseName = "Graphic Design" },
                new StudentDetail { StudentID = 2, StudentName = "Daniel Sam", City = "Jaffna", CourseName = "Mobile App Development" },
                new StudentDetail { StudentID = 3, StudentName = "Hansi Silva", City = "Colombo", CourseName = "Web Development" },
                new StudentDetail { StudentID = 4, StudentName = "Ranidu Heath", City = "Galle", CourseName = "Mobile App Development" },
                new StudentDetail { StudentID = 5, StudentName = "Praneeth Wijesinghe", City = "Kandy", CourseName = "Java" },
                new StudentDetail { StudentID = 6, StudentName = "Nuwani Hearth", City = "Rathnapura", CourseName = "Web Development" }
            };

            return View(studentsData);
        }
    }
}

