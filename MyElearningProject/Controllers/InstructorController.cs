using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class InstructorController : Controller
    {
        ELearningContext context = new ELearningContext();
      
        public ActionResult Index()
        {
            var values = context.Instructors.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInstructor(Instructor ınstructor)
        {
            context.Instructors.Add(ınstructor);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteInstructor(int id)
        {
            var values = context.Instructors.Find(id);
            context.Instructors.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateInstructur(int id)
        {
            var values = context.Instructors.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateInstructur(Instructor instructor)
        {
            var values = context.Instructors.Find(instructor.InstructorID);
            values.Name = instructor.Name;
            values.Surname = instructor.Surname;
            values.ImageUrl = instructor.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}