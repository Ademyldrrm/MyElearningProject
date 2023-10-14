using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class ContactPageController : Controller
    {
        // GET: ContactPage
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public ActionResult PartialContact()
        {
            return PartialView();
        }
    }
}