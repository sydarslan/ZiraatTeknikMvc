using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace ZiraatTeknikMvc.Controllers.Admin
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category category)
        {
            CategoryValidator cv = new CategoryValidator(); //validatordeki koşulları kontrolü
            ValidationResult results = cv.Validate(category);
            if (results.IsValid)
            {
                category.CategoryStatus = true;
                
                cm.CategoryAdd(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public PartialViewResult CategoryAddPartial()
        {

            return PartialView();
        }
        public ActionResult CategoryDelete(int id)
        {
            var categoryvalues = cm.GetById(id);
            categoryvalues.CategoryStatus = false;
            cm.CategoryDelete(categoryvalues);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CategoryUpdate(int id)
        {
            var categoryvalues = cm.GetById(id);
            return View(categoryvalues);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}