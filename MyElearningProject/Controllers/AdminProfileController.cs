using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class AdminProfileController : Controller
    {
        // GET: AdminProfile
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.AdminRegisters.ToList();
            return View(values);
        }
    }
}