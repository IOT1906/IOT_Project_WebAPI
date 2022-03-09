using IOT__Domain.outPutmodel;
using IOT_Project_MyDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT__WebApi.Controllers
{

    [ApiController]
    public class ProccessController : ControllerBase
    {
        private MyDbContext db;
        public ProccessController(MyDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        [Route("api/ProccessIF")]
        public ActionResult ProccessIF(int pageindex,int pagesize,string account)
        {
            var ss = (from a in db.BPMInstProcSteps.ToList()
                     join b in db.BPMInstTasks.ToList()
                     on a.TaskID equals b.TaskID
                     select new outputmodels
                     {
                         StepID=a.StepID,
                         TaskID=b.TaskID,
                         ProcessName=a.ProcessName,
                         OwnerAccount=a.OwnerAccount,
                         OwnerAccounts=b.OwnerAccount,
                         SelAction=a.SelAction,
                         SerialNum=b.SerialNum,
                         State=b.State
                     }).ToList();
            if (account!=null)
            {
                ss = ss.Where(x => x.OwnerAccount == account).ToList();
            }
            ss = ss.Where(x => x.SelAction == null).ToList();
            ss = ss.Where(x => x.State == "Running   ").ToList();
            var total = ss.Count();
            var list = ss.OrderBy(c => c.TaskID).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return Ok(new { total=total,list=list});
        }
    }
}
