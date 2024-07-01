using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPROJECT.Models
{
    public class CompanyInsert
    {
        [Required(ErrorMessage = "enter the name")]
        public string Cname { get; set; }

        [EmailAddress(ErrorMessage = "enter valid email")]
        public string Cemail { get; set; }

        [Required(ErrorMessage = "enter the address")]
        public string Caddress { get; set; }

        [Required(ErrorMessage = "enter phone number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "enter valid number")]
        public long contact { get; set; }

        public string Cstatus { get; set; }

        public string username { get; set; }

        public string pass { get; set; }

        [Compare("pass", ErrorMessage = "password mismatch")]
        public string cpass { get; set; }

        public string cmpnymsg { get; set; }

    }
}