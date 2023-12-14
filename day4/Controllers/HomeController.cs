using Practice_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice_WebApp.Models;

namespace Practice_WebApp.Controllers
{
    public class HomeController : Controller
    {
      

        public string Index()
        {
            List<string> l = new List<string>() { "Jeet", "Adnan", "Bilal", "Arjun", "Arif", "Sachin" };
            string ss = "";
            foreach (string s in l)
            {
                ss= ss + s+"\n";
               

            }
            return ss;
           
        }
        public ActionResult Index12()
        {
            CLIENT c = new CLIENT() { Id=1,Name="Jeet",Address="Mira Road"};

            
             //   return View("~/Views/MyView/MyView.cshtml");
             return View(c);
           
        }
        public ActionResult Index14() {
        return View();
        }
        public ActionResult Index15()
        {
            return View();
        }
        public string Index13(int a,string s)
        {

            //if (a == 1)
            //{
            //    return "Hey Jeet Welcome";
            //}
             if (s=="abc" && a==1) {
                return "Welcome to Nimap Infotech";
            }
            else
            {
                return "No data Found";
            }
            
        }

    }
}