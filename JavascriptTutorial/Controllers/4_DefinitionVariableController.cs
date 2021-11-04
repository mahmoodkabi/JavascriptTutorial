using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptTutorial.Controllers
{
    public class DefinitionVariableController : Controller
    {

        public ActionResult DefinitionVariable()
        {
            string lessonName = "تعریف متغیر";
            //lessonName = 100;

            return View();
        }
    }
}