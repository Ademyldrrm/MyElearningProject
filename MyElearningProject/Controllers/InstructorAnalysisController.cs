using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;

namespace MyElearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {

            return View();
        }
        public PartialViewResult InstructorPanelPartial()
          
        {
            int id = 2;
            var values = context.Instructors.Where(x => x.InstructorID == id).ToList();
            var v1 = context.Instructors.Where(x => x.Name == "Adem" && x.Surname == "Yıldırım").Select(y => y.InstructorID).FirstOrDefault();
            ViewBag.courseCount = context.Courses.Where(x => x.InstructorID == 2).Count();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(x => x.CourseID).ToList();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseID)).Count();


            return PartialView(values);
        }
        public PartialViewResult CommentPartial()
        {


            var v1 = context.Instructors.Where(x => x.Name == "Adem" && x.Surname == "Yıldırım").Select(y => y.InstructorID).FirstOrDefault();
         
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(x => x.CourseID).ToList();
           
            var v3 = context.Comments.Where(x => v2.Contains(x.CourseID)).ToList();
                return PartialView(v3);
        }
        public PartialViewResult CourseListByInstructor()
        {
            var values = context.Courses.Where(x => x.InstructorID == 2).ToList();
            return PartialView(values);
        }
    }
}