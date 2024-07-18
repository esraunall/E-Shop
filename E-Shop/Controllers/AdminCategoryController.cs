﻿using BusinessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace E_Shop.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(categoryRepository.List());
        }

        public ActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Category data)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Insert(data);

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "bir hata oluştu");
            return View();
        }

        public ActionResult Update(int id)
        {
            var update = categoryRepository.GetById(id);
            return View(update);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Update(Category p) 
        {
            if (ModelState.IsValid)
            {
                var update = categoryRepository.GetById(p.Id);
                update.Name = p.Name;
                update.Description = p.Description;
                categoryRepository.Update(update);
                return RedirectToAction("Index");
        }
            ModelState.AddModelError("", "Bir hata oluştu");
            return View();

        }

        public ActionResult Delete(int id)
        {
            var cat = categoryRepository.GetById(id);
            categoryRepository.Delete(cat);

            return RedirectToAction("Index");
        }
    }
}