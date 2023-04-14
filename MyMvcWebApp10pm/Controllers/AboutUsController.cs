using MyMvcWebApp10pm.Models;
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


        public ActionResult SendData()
        {
            ViewBag.info = "Hello World";
            ViewBag.info1 = "Hello World 1";
            return View();
        }


        public ActionResult SendData2()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Shiva";
            obj.EmpSalary = 10000;

            ViewBag.Emp = obj;

           
            return View();
        }

        public ActionResult SendData3()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Shiva";
            obj.EmpSalary = 10000;


            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "chiranjeevi";
            obj1.EmpSalary = 20000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Sabita";
            obj2.EmpSalary = 30000;


            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            ViewBag.listEmp = listObj;


            return View();
        }





    }
}

//calling index method to get Contactus View page  ----Done
//calling the index method to get dashboard view page of default controller-----
//how to pass data from controller to view page single string , object,list of Object
