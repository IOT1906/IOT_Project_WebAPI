using Api.Controllers;
using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.InputModel;
using IOT_Priject_Domin.InputModels;
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
        private IConfiguration configuration;
        public FlowController(IConfiguration configuration) : base(configuration)
        {



        }
        //第一周流程

        
        /// <summary>
        /// 发起请假流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/startleave")]
        public void StartLeave(PlanAll model)
        {
            var xml = CollectionToSqlXml<Departure>(model.PlanDate);
            StartProccess(xml, model);
        }
        /// <summary>
        /// 年度计划流程
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/StartPlan")]
        public void StartPlan(InputAnnual_plans annual)
        {
            var xml = CollectionToSqlXml<Annual_plan>(annual.Annual_plans);
            var xml1 = CollectionToSqlXml<Expected_increase_this_year>(annual.IOT_Priject_Domininput);
            StartProccess(xml + xml1, annual);
        }












        //二周流程发起

        /// <summary>
        /// 发起日常表单流程
        /// </summary>
        /// <param name="model"></param>

        [HttpPost, Route("api/Reception")]
        public void Reception(ReceAll model)
        {
            var xml = CollectionToSqlXml<ReceItemDetails>(model.ReceItemDetails);
            var xmls = CollectionToSqlXml<ReceItineraryDetails>(model.ReceItineraryDetails);
            var xmlss = CollectionToSqlXml<Receptionbase>(model.Receptionbase);
            StartProccess(xml + xmls + xmlss, model);
        }
        /// <summary>
        /// 用章计划流程
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/Startuse")]
        public void Startuse(Use_sealinput sealinput)
        {
            var xml = CollectionToSqlXml<Use_seal>(sealinput.Use_sealing);
            StartProccess(xml, sealinput);
        }
        /// <summary>
        /// 刻章计划流程
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/StartEngrave")]
        public void StartEngrave(Engrave_chapterinput sealinput)
        {
            var xml = CollectionToSqlXml<Engrave_chapter>(sealinput.Engrave);
            StartProccess(xml, sealinput);
        }


    }
}
