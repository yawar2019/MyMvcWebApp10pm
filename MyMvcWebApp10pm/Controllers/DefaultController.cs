using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWebApp10pm.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Dashboard()
        {
            ViewBag.tiger = "Dashboard Page is Called";
            return View();
        }
    }
}