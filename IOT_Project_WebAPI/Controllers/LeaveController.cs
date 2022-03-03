using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.Model;
using IOT_Project_IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
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
        private IConfiguration configuration;
        public LeaveController(LeaveIservices db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
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
