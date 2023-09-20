using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class InstructorController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            ViewBag.sayfa = "Eğitmen Sayfası";
            ViewBag.aciklama = "Eğitmen Listeleme Sayfası";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.Instructors.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddInstructor()
        {
            ViewBag.sayfa = "Eğitmen Sayfası";
            ViewBag.aciklama = "Eğitmen Ekleme Sayfası";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
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
            ViewBag.sayfa = "Eğitmen Sayfası";
            ViewBag.aciklama = "Eğitmen Güncelleme Sayfası";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
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