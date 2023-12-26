using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice02.Models;
namespace Practice02.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student s1 = new Student() { 
               Name = "Tanvir Ahmend",
               Id = "1122",
               DOB = "12.12.12"
            };
            return View(s1);

        }
        public ActionResult List()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student s1 = new Student()
                {
                    Name = "Tanvir Ahmend",
                    Id = "1122",
                    DOB = "12.12.12"
                };
                students.Add(s1);
            }
            return View(students);
        }
    }
}