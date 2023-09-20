using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Entities;
using MyElearningProject.DAL.Context;

namespace MyElearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.sayfa = "Referans Sayfası";
            ViewBag.aciklama = "Referans Listeleme Sayfası";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.Testimonials.ToList();
            return View(values);
        }
            [HttpGet]
            public ActionResult AddTestimonial()
            {
                ViewBag.sayfa = "Referans Sayfası";
                ViewBag.aciklama = "Referans Ekleme Sayfası";
                TempData["PageTitle"] = ViewBag.sayfa;
                TempData["PageDescription"] = ViewBag.aciklama;
                return View();
            }
            [HttpPost]
            public ActionResult Addtestimonial(Testimonial testimonial)
            {
            context.Testimonials.Add(testimonial);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = context.Testimonials.Find(id);
            context.Testimonials.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            ViewBag.sayfa = "Referans Sayfası";
            ViewBag.aciklama = "Referans Güncelleme Sayfası";
            TempData["PageTitle"] = ViewBag.sayfa;
            TempData["PageDescription"] = ViewBag.aciklama;
            var values = context.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var values = context.Testimonials.Find(testimonial.TestimonialID);
           
            values.NameSurname = testimonial.NameSurname;
            values.Title = testimonial.Title;
            values.ImageUrl = testimonial.ImageUrl;
            values.Comment = testimonial.Comment;
            values.Status = testimonial.Status;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
    }