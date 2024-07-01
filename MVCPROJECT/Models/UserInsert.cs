using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPROJECT.Models
{
    public class UserInsert
    {
        public int uid { get; set; }

        [Required(ErrorMessage = "enter the name")]
        public string name { get; set; }

        [Range(18,50, ErrorMessage = "enter the age")]
        public int age { get; set; }

        public string Gen { get; set; }

        [EmailAddress(ErrorMessage ="enter valid email")]
        public string email { get; set; }

        [Required(ErrorMessage = "enter phone number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "enter valid number")]
        public long phone { get; set; }

        [Required(ErrorMessage = "enter the address")]
        public string addr { get; set; }

        public string state { get; set; }

        public string qual { get; set; }

        public string skills { get; set; }

        public string experience { get; set; }

        public string sts { get; set; }

        public string Uname { get; set; }

        public string pwd { get; set; }

        [Compare("pwd", ErrorMessage = "password mismatch")]
        public string cnpass { get; set; }

        public string umsg { get; set; }
    }
}