﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class LoginPanelController : Controller
    {
        // GET: LoginPanel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialLogin()
        {
            return PartialView();
        }
    }
}