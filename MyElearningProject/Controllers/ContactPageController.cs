using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;


namespace MyElearningProject.Controllers
{
    public class ContactPageController : Controller
    {
        // GET: ContactPage
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return PartialView("PartialContact");
        }
        public ActionResult PartialContactInformation()
        {
            var values = context.ContactInformations.ToList();
            return PartialView(values);

        }
    }
}