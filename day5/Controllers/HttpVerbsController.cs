using Revision_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Revision_WebApp.Controllers
{
    public class HttpVerbsController : Controller
    {
        // GET: HttpVerbs
        [HttpGet]
        public ActionResult Index(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            return View();
        }
        [HttpPut]
        public ActionResult Update(int id,Student student)
        {
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}