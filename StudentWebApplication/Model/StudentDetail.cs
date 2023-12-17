using Microsoft.AspNetCore.Mvc;

namespace StudentWebApplication.Model
{
    public class StudentDetail
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }
        public string CourseName { get; set; }
    }
 
}
