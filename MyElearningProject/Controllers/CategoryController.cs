﻿using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CategoryController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.sayfa = "Kategori Sayfası";
            ViewBag.aciklama = "Kategori Listeleme";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            ViewBag.sayfa = "Kategori Sayfası";
            ViewBag.aciklama = "Kategori Listeleme";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            ViewBag.sayfa = "Kategori Sayfası";
            ViewBag.aciklama = "Kategori Listeleme";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.Categories.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var values = context.Categories.Find(category.CategoryID);
            values.CategoryID = category.CategoryID;
            values.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}