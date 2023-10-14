using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;


namespace MyElearningProject.Controllers
{
    public class AboutPageController : Controller
    {
        // GET: AboutPage
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