using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWebApp10pm.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
         
        public ActionResult Index()
        {
           
            //ViewBag.tiger =1;
            // return View("ContactUS");
            return View("~/Views/Default/Dashboard.cshtml");

        }

        [NonAction]
        public string Index2()
        {
            return "Hello World";
        }

        public ActionResult ContactUS()
        {
            ViewBag.tiger = "Contact to tiger";
            return View();
        }

        public ActionResult JumpMethod()
        {
            return RedirectToAction("Dashboard", "Default");
        }



    }
}

//calling index method to get Contactus View page  ----Done
//calling the index method to get dashboard view page of default controller-----
