using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MyElearningProject.Controllers
{
    public class CourseController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Courses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCourse()
        {
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;
            List<SelectListItem> intructors = (from y in context.Instructors.ToList().OrderBy(z=>z.Name)
                                               select new SelectListItem
                                               {
                                                   Text = y.Name + " "+ y.Surname,
                                                   Value = y.InstructorID.ToString()
                                               }).ToList();
            ViewBag.v2 = intructors;
            return View();
            
        }
        [HttpPost]
        public ActionResult CreateCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCourse(int id)
        {
            var values = context.Courses.Find(id);
            context.Courses.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCourse(int id)
        {

            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;
            List<SelectListItem> intructors = (from y in context.Instructors.ToList().OrderBy(z => z.Name)
                                               select new SelectListItem
                                               {
                                                   Text = y.Name + " " + y.Surname,
                                                   Value = y.InstructorID.ToString()
                                               }).ToList();
            ViewBag.v2 = intructors;
            var values = context.Courses.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            var values = context.Courses.Find(course.CourseID);
            values.Title = course.Title;
            values.CategoryID = course.CategoryID;
            values.Duration = course.Duration;
            values.ImageUrl = course.ImageUrl;
            values.InstructorID = course.InstructorID;
            values.Price = course.Price;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}