using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPROJECT.Models
{
    public class SearchJob
    {
        public SearchJob()
        {
            selectjob = new List<jsearch>();
            insertse = new jsearch();
        }
        public jsearch insertse { get; set; }
        public List<jsearch> selectjob { get; set; }
    }
    public class jsearch
    {
        public int jobid { get; set; }

        public int cmpnyid { get; set; }

        public string jname { get; set; }

        public string jdescription { get; set; }

        public long salary { get; set; }

        public string rskills { get; set; }

        public string qualification { get; set; }

        public string jvacancy { get; set; }

        public string jstatus { get; set; }

        public DateTime Edate { get; set; }

        public DateTime LApplydate { get; set; }

        public string jmsg { get; set; }
    }
}
