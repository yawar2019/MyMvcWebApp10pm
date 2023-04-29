using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MyMvcWebApp10pm.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("sqlcon")
        {

        }


        public DbSet<EmployeeModel> employeeModels { get; set; }
    }
}