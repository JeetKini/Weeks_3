using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomName = "Jeet";
            ViewBag.MyList=new List<string>() {"jeet","adnan" };

            List<Employee> employees = new List<Employee>() {
            new Employee(){Email= "Jeet@gmail.com",Id=1,Name="jeet"},
            new Employee(){Email= "Meet@gmail.com",Id=2,Name="Meet"},
            new Employee(){Email= "Geet@gmail.com",Id=3,Name="Geet"}
            };
            ViewBag.MyEmpList=employees;

            return View();
        }
        public ActionResult Demo()
        {
            ViewData["myKey"]="This is My ValueData";
            ViewData["MyList"] = new List<string>() { "jeet", "adnan" };
            return View();
        }
    }
}