using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        public ActionResult Index()
        {
            var headingValues = _hm.GetCategoryList();
            return View(headingValues);
        }
    }
}