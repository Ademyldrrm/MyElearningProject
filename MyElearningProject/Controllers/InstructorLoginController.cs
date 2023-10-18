using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class InstructorLoginController : Controller
    {
        // GET: InstructorLogin
        ELearningContext context = new ELearningContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Instructor ınstructor)
        {
            var values = context.Instructors.FirstOrDefault(x => x.Name == ınstructor.Name && x.Password == ınstructor.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Name, false);
                Session["CurrentName"] = values.Name;
                Session.Timeout = 60;
                return RedirectToAction("Index", "InstructorAnalysis");
            }
            return View();
        }
    }
}