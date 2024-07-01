﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCPROJECT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PROJECTMVCEntities : DbContext
    {
        public PROJECTMVCEntities()
            : base("name=PROJECTMVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company_REG> Company_REG { get; set; }
        public virtual DbSet<JobApply> JobApplies { get; set; }
        public virtual DbSet<JobDetail> JobDetails { get; set; }
        public virtual DbSet<JobSearch> JobSearches { get; set; }
        public virtual DbSet<Login_Tab> Login_Tab { get; set; }
        public virtual DbSet<User_REG> User_REG { get; set; }
    
        public virtual int SP_CompanyReg(Nullable<int> cid, string cna, string em, string addr, Nullable<long> con, string status)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var cnaParameter = cna != null ?
                new ObjectParameter("cna", cna) :
                new ObjectParameter("cna", typeof(string));
    
            var emParameter = em != null ?
                new ObjectParameter("em", em) :
                new ObjectParameter("em", typeof(string));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var conParameter = con.HasValue ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(long));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CompanyReg", cidParameter, cnaParameter, emParameter, addrParameter, conParameter, statusParameter);
        }
    
        public virtual int SP_JobApply(Nullable<int> jid, Nullable<int> cid, Nullable<int> userid, Nullable<System.DateTime> ad, string resume, string applysts)
        {
            var jidParameter = jid.HasValue ?
                new ObjectParameter("jid", jid) :
                new ObjectParameter("jid", typeof(int));
    
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            var adParameter = ad.HasValue ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(System.DateTime));
    
            var resumeParameter = resume != null ?
                new ObjectParameter("resume", resume) :
                new ObjectParameter("resume", typeof(string));
    
            var applystsParameter = applysts != null ?
                new ObjectParameter("applysts", applysts) :
                new ObjectParameter("applysts", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_JobApply", jidParameter, cidParameter, useridParameter, adParameter, resumeParameter, applystsParameter);
        }
    
        public virtual int SP_JobDetails(Nullable<int> cid, string jname, string jdes, Nullable<long> sal, string rSkills, string qual, string jVacancy, string jsts, Nullable<System.DateTime> eDate, Nullable<System.DateTime> lDate)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var jnameParameter = jname != null ?
                new ObjectParameter("Jname", jname) :
                new ObjectParameter("Jname", typeof(string));
    
            var jdesParameter = jdes != null ?
                new ObjectParameter("jdes", jdes) :
                new ObjectParameter("jdes", typeof(string));
    
            var salParameter = sal.HasValue ?
                new ObjectParameter("sal", sal) :
                new ObjectParameter("sal", typeof(long));
    
            var rSkillsParameter = rSkills != null ?
                new ObjectParameter("RSkills", rSkills) :
                new ObjectParameter("RSkills", typeof(string));
    
            var qualParameter = qual != null ?
                new ObjectParameter("qual", qual) :
                new ObjectParameter("qual", typeof(string));
    
            var jVacancyParameter = jVacancy != null ?
                new ObjectParameter("JVacancy", jVacancy) :
                new ObjectParameter("JVacancy", typeof(string));
    
            var jstsParameter = jsts != null ?
                new ObjectParameter("Jsts", jsts) :
                new ObjectParameter("Jsts", typeof(string));
    
            var eDateParameter = eDate.HasValue ?
                new ObjectParameter("eDate", eDate) :
                new ObjectParameter("eDate", typeof(System.DateTime));
    
            var lDateParameter = lDate.HasValue ?
                new ObjectParameter("LDate", lDate) :
                new ObjectParameter("LDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_JobDetails", cidParameter, jnameParameter, jdesParameter, salParameter, rSkillsParameter, qualParameter, jVacancyParameter, jstsParameter, eDateParameter, lDateParameter);
        }
    
        public virtual ObjectResult<SP_JSCheck_Result> SP_JSCheck()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_JSCheck_Result>("SP_JSCheck");
        }
    
        public virtual int SP_JSCheck1(string qry)
        {
            var qryParameter = qry != null ?
                new ObjectParameter("qry", qry) :
                new ObjectParameter("qry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_JSCheck1", qryParameter);
        }
    
        public virtual int SP_Login(string una, string pwd, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Login", unaParameter, pwdParameter, status);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_LoginID(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_LoginID", unaParameter, pwdParameter);
        }
    
        public virtual int SP_LoginInsert(Nullable<int> rid, string una, string pw, string ltype, string lstatus)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            var ltypeParameter = ltype != null ?
                new ObjectParameter("ltype", ltype) :
                new ObjectParameter("ltype", typeof(string));
    
            var lstatusParameter = lstatus != null ?
                new ObjectParameter("lstatus", lstatus) :
                new ObjectParameter("lstatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_LoginInsert", ridParameter, unaParameter, pwParameter, ltypeParameter, lstatusParameter);
        }
    
        public virtual ObjectResult<string> SP_LoginType(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_LoginType", unaParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_MaxLoginID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_MaxLoginID");
        }
    
        public virtual int SP_UserInsert(Nullable<int> id, string na, Nullable<int> ag, string gen, string em, Nullable<long> phno, string addr, string st, string qual, string sk, string ex, string status)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var agParameter = ag.HasValue ?
                new ObjectParameter("ag", ag) :
                new ObjectParameter("ag", typeof(int));
    
            var genParameter = gen != null ?
                new ObjectParameter("gen", gen) :
                new ObjectParameter("gen", typeof(string));
    
            var emParameter = em != null ?
                new ObjectParameter("em", em) :
                new ObjectParameter("em", typeof(string));
    
            var phnoParameter = phno.HasValue ?
                new ObjectParameter("phno", phno) :
                new ObjectParameter("phno", typeof(long));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var stParameter = st != null ?
                new ObjectParameter("st", st) :
                new ObjectParameter("st", typeof(string));
    
            var qualParameter = qual != null ?
                new ObjectParameter("qual", qual) :
                new ObjectParameter("qual", typeof(string));
    
            var skParameter = sk != null ?
                new ObjectParameter("sk", sk) :
                new ObjectParameter("sk", typeof(string));
    
            var exParameter = ex != null ?
                new ObjectParameter("ex", ex) :
                new ObjectParameter("ex", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UserInsert", idParameter, naParameter, agParameter, genParameter, emParameter, phnoParameter, addrParameter, stParameter, qualParameter, skParameter, exParameter, statusParameter);
        }
    }
}
