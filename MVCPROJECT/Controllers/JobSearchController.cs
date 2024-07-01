using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPROJECT.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace MVCPROJECT.Controllers
{
    public class JobSearchController : Controller
    {
        PROJECTMVCEntities dbobj = new PROJECTMVCEntities();
        // GET: JobSearch
        public ActionResult JobSearch_Pageload()
        {
            return View(GetData());
        }
        private SearchJob GetData()
        {
            var joblist = new SearchJob();
            List<string> lst = new List<string>();
            var job = dbobj.JobDetails.ToList();
            foreach (var e in job)
            {
                var jobclass = new jsearch();
                jobclass.jobid = e.Job_ID;
                jobclass.cmpnyid = e.Company_ID;
                jobclass.jname = e.Job_Name;
                jobclass.jdescription = e.Job_Description;
                jobclass.salary = e.Salary;
                jobclass.rskills = e.Required_Skills;
                jobclass.qualification = e.Qualification;
                jobclass.jvacancy = e.Job_Vacancy;
                jobclass.jstatus = e.Job_Status;
                jobclass.Edate = e.Entry_Date;
                jobclass.LApplydate = e.Last_ApplyDate;
                joblist.selectjob.Add(jobclass);
                var s = jobclass.rskills;
                lst.Add(s);
                TempData["ski"] = string.Join(" ", lst);
            }
            return joblist;
        }
        public ActionResult JobSearch_Click(SearchJob clsobj)
        {
            string qry = "";
            if (!string.IsNullOrWhiteSpace(clsobj.insertse.jname))
            {
                qry += "and Job_Name like '%" + clsobj.insertse.jname + "%'";
            }
            if (!string.IsNullOrWhiteSpace(clsobj.insertse.rskills))
            {
                qry += "and Required_Skills like'%" + clsobj.insertse.rskills + "%'";
            }
            return View("JobSearch_Pageload", getdata1(clsobj, qry));
        }
        private SearchJob getdata1(SearchJob clsobj, string qry)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_JSCheck1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@qry", qry);
                con.Open();
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    var joblist = new SearchJob();
                    while (dr.Read())
                    {
                        var jobcls = new jsearch();
                        jobcls.cmpnyid = Convert.ToInt32(dr["Company_ID"].ToString());
                        jobcls.jname = dr["Job_Name"].ToString();
                        jobcls.jdescription = dr["Job_Description"].ToString();
                        jobcls.salary = Convert.ToInt32(dr["Salary"].ToString());
                        jobcls.rskills = dr["Required_Skills"].ToString();
                        jobcls.qualification = dr["Qualification"].ToString();
                        jobcls.jvacancy = dr["Job_Vacancy"].ToString();
                        jobcls.jstatus = dr["Job_Status"].ToString();
                        jobcls.Edate = Convert.ToDateTime(dr["Entry_Date"].ToString());
                        jobcls.LApplydate = Convert.ToDateTime(dr["Last_ApplyDate"].ToString());
                        joblist.selectjob.Add(jobcls);
                    }
                    con.Close();
                    return joblist;
                }
            }
        }
    }
}