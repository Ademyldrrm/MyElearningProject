using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
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