using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager _hm = new HeadingManager(new EfHeadingDal());

        CategoryManager _cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var headingValues = _hm.GetCategoryList();
            return View(headingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in _cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()

                                                  }).ToList();
            ViewBag.vlc = valueCategory;

            return View();
        }


        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}