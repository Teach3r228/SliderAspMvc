using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SliderAspTest.Controllers
{
    public class HomeController : Controller
    {
        SliderTestContext context = new SliderTestContext();
        public ActionResult Index()
        {
            var FileName = context.TblImages.ToList();
            return View(FileName);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult  AddImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddImage(TblImages dto)
        {
            return View();
        }
    }
}