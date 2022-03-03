using Api.Controllers;
using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.InputModel;
using IOT_Priject_Domin.Model;
using IOT_Project_IServices;
using IOT_Project_Services;
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
    /// 年度计划控制器
    /// </summary>
    [ApiController]
    public class Annual_PlanController : BaseController
    {
        public Annual_PlanController(IConfiguration configuration) : base(configuration)
        {
        }
        /// <summary>
        /// 年度计划
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/StartPlan")]
        public void StartPlan(InputAnnual_plans annual)
        {
            var xml = CollectionToSqlXml<Annual_plan>(annual.Annual_plans);
            var xml1 = CollectionToSqlXml<Expected_increase_this_year>(annual.IOT_Priject_Domininput);
            StartProccess(xml+ xml1, annual);
        }

        

    }
}
