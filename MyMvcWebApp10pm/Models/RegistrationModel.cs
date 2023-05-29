using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMvcWebApp10pm.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="FirstName is Required")]
        public string FirstName { get; set; }
        [Required]
        [Range(18,60,ErrorMessage ="18-60 isvalid")]
        public int age { get; set; }
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="Pwd and Cpwd is mismatch")]
        public string cmpPwd { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Emai id is invalid")]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="More then 10 characters not accepted")]
        public string Country { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public string DotNet { get; set; }
        public string Java { get; set; }
        public string Customers { get; set; }
    }
}