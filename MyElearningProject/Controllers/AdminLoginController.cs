using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Login
        ELearningContext context = new ELearningContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdminRegister adminRegister)
        {
            var values = context.AdminRegisters.FirstOrDefault(x => x.AdminName == adminRegister.AdminName && x.Password == adminRegister.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.AdminName, false);
                Session["CurrentName"] = values.AdminName;
                Session.Timeout = 60;
                return RedirectToAction("Index", "AdminProfile");
            }
            return View();
        }
    }
}