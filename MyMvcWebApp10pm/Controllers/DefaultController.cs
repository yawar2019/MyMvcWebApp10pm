using MyMvcWebApp10pm.Models;
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
        EmployeeContext db = new EmployeeContext();
        public ActionResult Dashboard()
        {
          
            return View(db.employeeModels.ToList());
        }
    }
}