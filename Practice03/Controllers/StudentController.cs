using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice03.Models;
namespace Practice03.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateSubmit(Student s) { 
            // 4 ways of receving value from form to action 
            // From httpRequestBase :- Request(instance) ; 
            return View(s);
        }
    }
}