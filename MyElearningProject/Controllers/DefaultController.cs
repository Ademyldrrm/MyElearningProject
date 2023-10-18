using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialCarousel()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = context.AboutUs.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCategories()
        {
            var value = context.Categories.OrderBy(x => x.CategoryID).Skip(2).FirstOrDefault();
            return PartialView(new List<Category> { value });
        }
        public PartialViewResult PartialCourse()
        {
            var values = context.Courses.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialInstructors()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult Partial1()
        {
            var values = context.Categories.OrderByDescending(x => x.CategoryID).Take(1).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = context.Categories.OrderBy(x => x.CategoryID).Take(2).ToList();
            return PartialView(values);
        }

    }
}