using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice01.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult List()
        {
            int a = 10;
            int b = 20;
            int c = a + b;

            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;

            string[] names = new string[3];
            names[0] = "Tanvir";
            names[1] = "Sabbir";
            names[2] = "Hasan";

            ViewBag.Names = names;
            return View();
        }
        public ActionResult CreatePerson()
        {
            return View();
        }
    }
}