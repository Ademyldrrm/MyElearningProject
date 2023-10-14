using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CoursePageController : Controller
    {
        // GET: CoursePage
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
    }
}