using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class LoginInsertController : Controller
    {
        PROJECTMVCEntities dbobj = new PROJECTMVCEntities();
        // GET: LoginInsert
        public ActionResult Login_Pageload()
        {
            return View();
        }
        public ActionResult UserHome_Page()
        {
            return View();
        }
        public ActionResult Company_HomePage()
        {
            return View();
        }
        public ActionResult Login_Click(Login objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.SP_Login(objcls.uname, objcls.password, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    var uid = dbobj.SP_LoginID(objcls.uname, objcls.password).FirstOrDefault();
                    Session["uid"] = uid;
                    var logt = dbobj.SP_LoginType(objcls.uname, objcls.password).FirstOrDefault();
                    if (logt == "user")
                    {
                        return RedirectToAction("UserHome_Page");
                    }
                    else if (logt == "admin")
                    {
                        return RedirectToAction("Company_HomePage");
                    }
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "invalid login";
                    return View("Login_Pageload", objcls);
                }
            }
            return View("Login_Pageload", objcls);
        }
    }
}