using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;

namespace MyElearningProject.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile

        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values= Session["CurrentMail"];
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = context.Students.Where(x => x.Email == values).Select(y => y.Name + "" + y.Surname).FirstOrDefault();
            return View();
        }
        public ActionResult MYCourseList()
        {
            var values = Session["CurrentMail"].ToString();
            int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            var courseList = context.Processes.Where(x => x.StudentID == id).ToList();
            return View(courseList);
        }

    }
}