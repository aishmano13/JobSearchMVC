using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class ApplyJobController : Controller
    {
        PROJECTMVCEntities dbobj = new PROJECTMVCEntities();
        // GET: ApplyJob
        public ActionResult JobApply_Pageload(int cid, int jid)
        {
            TempData["cid"] = cid;
            TempData["jid"] = jid;
            return View();
        }

        public ActionResult JobApply_Click(JobApply clsobj, SearchJob obj, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/Resume");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);


                    var fullpath = Path.Combine("~/Resume", fname);
                    clsobj.Resume = fullpath;

                }
                int uid = Convert.ToInt32(Session["uid"]);
                int cid = Convert.ToInt32(TempData["cid"]);
                int jid = Convert.ToInt32(TempData["jid"]);

                dbobj.SP_JobApply(jid, cid, uid, clsobj.ApplyDate, clsobj.Resume, "Available");

                //clsobj.amsg = "successfully applied";
                return View("JobApply_Pageload");

            }
            return View("JobApply_Pageload");
        }

    }
}