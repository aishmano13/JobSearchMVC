using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class JobInsertController : Controller
    {
        PROJECTMVCEntities dbobj = new PROJECTMVCEntities();
        // GET: JobInsert
        public ActionResult JobInsert_Pageload()
        {

            return View();
        }
        public ActionResult JobInsert_Click(JobInsert objcls)
        {
            if(ModelState.IsValid)
            {
                int cid = Convert.ToInt32(Session["uid"]);
                dbobj.SP_JobDetails(cid, objcls.jname, objcls.jdescription, objcls.salary, objcls.rskills, objcls.qualification, objcls.jvacancy, objcls.jstatus, objcls.Edate, objcls.LApplydate);
                objcls.msg = "insert successfully";
            }
            return View("JobInsert_Pageload", objcls);
        }
    }
}