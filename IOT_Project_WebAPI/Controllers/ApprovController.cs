using IOT_Priject_Domin.OutPutModel;
using IOT_Project_MyDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Project_WebAPI.Controllers
{
   
    [ApiController]
    public class ApprovController : ControllerBase
    {
        private readonly MyDbContext _Sql;

        public ApprovController(MyDbContext Sql)
        {
            _Sql = Sql;
        }

        [HttpGet, Route("api/Approvals")]
        /// <summary>
        ///审批方法 
        /// </summary>
        public IActionResult Approvals(string account)
        {
            var list = from s in _Sql.BPMInstTasks.ToList()
                       join b in _Sql.BPMInstProcSteps.ToList()
                       on s.TaskID equals b.TaskID
                       select new OutPutModels
                       {
                           TaskId = s.TaskID,
                           StepId = b.StepID,
                           OwnerAccount = s.OwnerAccount,
                           ProcessName = s.ProcessName,
                           SelAction = b.SelAction,
                           State = s.State,
                       };
            if (account != null)
            {
                list = list.Where(x => x.OwnerAccount == account).ToList();
            }
            list = list.Where(x => x.SelAction == null).ToList();
            list = list.Where(x => x.State == "Running   ").ToList();
            return Ok(list);
        }

    }
}
