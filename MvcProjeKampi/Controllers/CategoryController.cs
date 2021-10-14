using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var _categoryvalues = cm.GetCategoryList();
            return View(_categoryvalues);
        }
        [HttpGet]  //Sayfa yüklendiği zaman çalışır.
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] //HttpPost Attribute devreye girdği zaman çalışacak.Sayfada bir butona basıldığında bir şey post edildiğinde çalışacak
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            CategoryValidator _categoryValidator = new CategoryValidator();
            ValidationResult results = _categoryValidator.Validate(p);        //Validate kontrol etmek.

            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage); //Metod yönlendirme ve hata mesajı verme
                }
            }

            return View();
        }
    }
}