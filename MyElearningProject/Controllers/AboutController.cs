using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.sayfa = "Hakkımızda Sayfası";
            ViewBag.aciklama = "Hakkımızda Listeleme";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.AboutUs.ToList();
            return View(values);
        }
            [HttpGet]
            public ActionResult AddAbout()
            {
                ViewBag.sayfa = "Hakkımızda Sayfası";
                ViewBag.aciklama = "Hakkımızda Ekleme Sayfası";
                TempData["PageTitle"] = ViewBag.sayfa;
                TempData["PageDescription"] = ViewBag.aciklama;
                return View();
            }
            [HttpPost]
            public ActionResult AddAbout(About about)
            {
                context.AboutUs.Add(about);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        public ActionResult DeleteAbout(int id)
        {
            var values = context.AboutUs.Find(id);
            context.AboutUs.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            ViewBag.sayfa = "Hakkımızda Sayfası";
            ViewBag.aciklama = "Hakkımızda Güncelleme Sayfası";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.AboutUs.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var values = context.AboutUs.Find(about.AboutID);
            values.Title = about.Title;
            values.Introduction = about.Introduction;
            values.Description = about.Description;
            values.ImageUrl = about.ImageUrl;
            values.Content = about.Content;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
    }