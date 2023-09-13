using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;

namespace MyElearningProject.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
      
        public ActionResult Index()
        {
            return View();
        }
    }
}