using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class PersonController : Controller
    {

        public ActionResult CreatePerson()
        {
            return View();
        }

        public ActionResult GetEveryOne()
        {
            //return Content("Hello World This is my wold");
            //return new EmptyResult();
            return HttpNotFound();
        }




        // GET: Person
   
    }
}