using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revision_WebApp.Controllers
{
    public class TempDataController : Controller
    {
 
        public ActionResult Index()
        {
            TempData["mm"] = "This is temp data";
            return View();
        }
        public ActionResult Index2()
        {
            Session.Abandon();
            ViewBag.ab = TempData["mm"];
            TempData.Keep("mm");
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.ab = TempData.Peek("mm");
            
            
            return View();
        }

    }
}