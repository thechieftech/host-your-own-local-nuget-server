using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheSharedLibrary;
using TheWebApp.Models;

namespace TheWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string theName)
        {
            if (!string.IsNullOrEmpty(theName))
            {
                var sharedclass = new SharedClass();
                var result = sharedclass.SayMyName(theName);
                var model = new FormVm
                {
                    Result = result
                };

                return View(model);
            }

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
    }
}