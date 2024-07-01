using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class UserRegController : Controller
    {
        PROJECTMVCEntities dbobj = new PROJECTMVCEntities();
        // GET: UserReg
        public ActionResult UserInsert_Pageload()
        {
            return View();
        }
        public ActionResult UserInsertClick(UserInsert clsobj)
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
                dbobj.SP_UserInsert(regid, clsobj.name, clsobj.age, clsobj.Gen, clsobj.email, clsobj.phone, clsobj.addr, clsobj.state, clsobj.qual, clsobj.skills, clsobj.experience,clsobj.sts);
                dbobj.SP_LoginInsert(regid, clsobj.Uname, clsobj.pwd, "user","active");
                clsobj.umsg = "successfully inserted";
                return View("UserInsert_Pageload", clsobj);
            }
            return View("UserInsert_Pageload", clsobj);
        }
    }
}