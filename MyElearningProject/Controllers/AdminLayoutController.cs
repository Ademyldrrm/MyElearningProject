using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialPageRowTitle()
        {
            TempData["sayfa"] = ViewBag.sayfa;
            TempData["aciklama"] = ViewBag.aciklama;
            return PartialView();
        }
        public PartialViewResult PartialPreloader()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}