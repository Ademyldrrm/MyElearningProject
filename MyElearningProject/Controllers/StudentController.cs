using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Entities;
using MyElearningProject.DAL.Context;

namespace MyElearningProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Students.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
    [HttpPost]
    public ActionResult AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteStudent(int id)
        {
            var values = context.Students.Find(id);
            context.Students.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var values = context.Students.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            var values = context.Students.Find(student.StudentID);
            values.Name = student.Name;
            values.Surname = student.Surname;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}