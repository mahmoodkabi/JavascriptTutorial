using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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


        public ActionResult SaveData(string bookName, string authorName, string translator, 
            int? pagesNumber, int? publicationYear)
        {
            //------------------------
            //ذخیره اطلاعات در دیتابیس
            //------------------------


            return Json("اطلاعات با موفقیت ذخیره گردید", JsonRequestBehavior.AllowGet);

        }






















        public ActionResult DefinitionVariable()
        {
            //string courseName = "آموزش جاوااسکریپت";
            //string description = 1400;

            return View();
        }
    }
}