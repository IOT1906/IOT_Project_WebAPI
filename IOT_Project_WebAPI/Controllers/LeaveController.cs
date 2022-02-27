using IOT_Priject_Domin.Model;
using IOT_Project_IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Project_WebAPI.Controllers
{
    /// <summary>
    /// 请假控制器
    /// </summary>
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly LeaveIservices db;

        public LeaveController(LeaveIservices db)
        {
            this.db = db;
        }
        /// <summary>
        /// Leave 添加
        /// </summary>
        /// <param name = "leave" ></ param >
        /// < returns ></ returns >
        [HttpPost]
        [Route("api/LeaveAdd")]
        public IActionResult LeaveAdd([FromBody] Leave leave)
        {
            return Ok(db.Add(leave));
        }
    }
}
