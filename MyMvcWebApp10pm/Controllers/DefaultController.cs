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

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection e)// public ActionResult Create(EmployeeModel e) // public ActionResult Create(string EmpName,int EmpSalary)
        {
            //EmployeeModel e = new EmployeeModel();
            //e.EmpName = EmpName;
            //e.EmpSalary = EmpSalary;

            EmployeeModel e1 = new EmployeeModel();
            e1.EmpName = e["EmpName"];
            e1.EmpSalary = Convert.ToInt32(e["EmpSalary"]);

            db.employeeModels.Add(e1);
            
            int result=db.SaveChanges();


            if (result > 0) {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
           
        }

        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.employeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel e) 
        {
           
            db.Entry(e).State=System.Data.Entity.EntityState.Modified;

            int result = db.SaveChanges();


            if (result > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }

        }

    }
}