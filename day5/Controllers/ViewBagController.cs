using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revision_WebApp.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
           // ViewBag.JK = "My name is Jeet Kini";
            ViewData["Hey"]= "This is my View Bag";
            List<string> list = new List<string>() {"A","B","C","D","E","F" };
            ViewData["Hello"] = list;
            return View();
        }
    }
}