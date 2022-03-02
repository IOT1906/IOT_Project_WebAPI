using Api.Controllers;
using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.InputModel;
using IOT_Priject_Domin.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public void StartLeave(PlanAll leave)
        {
            var xml = CollectionToSqlXml<Departure>(leave.PlanDate);
            StartProccess(xml,leave);
        }













    }
}
