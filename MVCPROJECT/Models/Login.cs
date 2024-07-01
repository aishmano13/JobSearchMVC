using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPROJECT.Models
{
    public class Login
    {
        [Required(ErrorMessage = "enter the username")]
        public string uname { get; set; }

        [Required(ErrorMessage = "enter the password")]
        public string password { get; set; }

        public string msg { get; set; }

        public string ltype { get; set; }

        public string lstatus { get; set;}
    }
}