using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class CompanyRegController : Controller
    {
        PROJECTMVCEntities dbobj = new PROJECTMVCEntities();
        // GET: CompanyReg
        public ActionResult CompanyInsert_Pageload()
        {
            return View();
        }
        public ActionResult CompanyInsert_Click(CompanyInsert clsobj)
        {
            if (ModelState.IsValid)
            {
                var getmaxid = dbobj.SP_MaxLoginID().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                dbobj.SP_CompanyReg(regid, clsobj.Cname, clsobj.Cemail, clsobj.Caddress, clsobj.contact,clsobj.Cstatus);
                dbobj.SP_LoginInsert(regid, clsobj.username, clsobj.pass, "admin","active");
                clsobj.cmpnymsg = "Successfully inserted";
                return View("CompanyInsert_Pageload", clsobj);
            }
            return View("CompanyInsert_Pageload", clsobj);
        }
    }
}