using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPROJECT.Models
{
    public class JobApply
    {
        public int Applyjobid { get; set; }

        public int jobid { get; set; }

        public int companyid { get; set; }

        public int userid { get; set; }

        public DateTime applydate { get; set; }

        public string resume { get; set; }

        public string applystatus { get; set; }

        public string amsg { get; set; }
    }
}