using IOT_Priject_Domin.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication21.Controllers;

namespace IOT_Project_WebAPI.Controllers
{
    
    [ApiController]
    public class FlowController : BaseController
    {

        public FlowController(IConfiguration configuration) : base(configuration)
        {
            
        }
        /// <summary>
        /// 发起请假流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/startleave")]
        public void StartLeave(Leave leave)
        {
            StartProccess<Leave>(leave);
        }


    }
}
