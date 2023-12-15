using Revision_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revision_WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
        [HttpGet]
        public ActionResult Index()
            {
            Employee emp = new Employee() { Id = 1, Name = "Jeet", Address = "Thane" };

            return View(emp);
        }
        [HttpPost]
        public ActionResult Store(Employee emp)
        {
            
            return View(emp); 
        
        }
    }
}