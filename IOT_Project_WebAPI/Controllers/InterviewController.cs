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
    /// 离职面谈控制器
    /// </summary>
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly LeaveIservices db;
        private IConfiguration configuration;
        public InterviewController(LeaveIservices db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        /// <summary>
        /// Interview 添加
        /// </summary>
        /// <param name = "leave" ></ param >
        /// < returns ></ returns >
        [HttpPost]
        [Route("api/InterviewAdd")]
        public IActionResult InterviewAdd([FromBody] Interview ljq)
        {
            return Ok(db.Add(ljq));
        }


      

    }
}
