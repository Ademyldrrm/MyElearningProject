using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.sayfa = "İletişim Sayfası";
            ViewBag.aciklama = "İletişim Listeleme";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.Contacts.ToList();
            return View(values) ;
        }
    }
}