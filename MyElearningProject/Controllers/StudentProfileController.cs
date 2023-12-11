using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class StudentProfileController : Controller
    {
        // GET: StudentProfile
        ELearningContext context = new ELearningContext();
        [Authorize]
        public ActionResult Index()
        {


            var values = Session["CurrentMail"];
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = context.Students.Where(x => x.Email == values).Select(y => y.Name + "" + y.Surname).FirstOrDefault();
            ViewBag.ımage = context.Students.Where(x => x.Email == values).Select(y => y.ImageUrl).FirstOrDefault();
            return View();
            
        }
        public ActionResult MYCourseList()
        {
            var values = Session["CurrentMail"].ToString();
            int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            var courseList = context.Courses
                .Where(c => context.Processes.Any(p => p.StudentID == id && p.CourseID == c.CourseID)).ToList();

            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;

            List<SelectListItem> instructors = (from y in context.Instructors.ToList().OrderBy(z => z.Name)
                                                select new SelectListItem
                                                {
                                                    Text = y.Name + " " + y.Surname,
                                                    Value = y.InstructorID.ToString()
                                                }).ToList();
            ViewBag.v2 = instructors;

            return View(courseList);
        }

        
        public ActionResult GivePointsCourse()
        {
            var values = context.Courses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CourseCommentAdd()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult CourseCommentAdd(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}