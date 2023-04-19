using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvcWebApp10pm.Models
{
    public class EmpDeptModel
    {
        public List<EmployeeModel> listEmp { get; set; }
        public List<DepartmentModel> listDept { get; set; }
    }
}