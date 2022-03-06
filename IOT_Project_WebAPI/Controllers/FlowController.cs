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
            var xml = CollectionToSqlXml<Leave>(model.PlanDate);
            StartProccess(xml, model);
        }
        /// <summary>
        /// 审批流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/StartAuitp")]
        public void StartAuitp(chooseinput baseModels)
        {
            StartAudit(baseModels);
        }
        ///// <summary>
        ///// 拒绝流程
        ///// </summary>
        ///// <param name="leave"></param>
        //[HttpPost, Route("api/StartTurn")]
        //public void StartTurn(chooseinput baseModels)
        //{
        //    StartDown(baseModels);
        //}

        /// <summary>
        /// 发起人力资源申请
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/RAdd")]
        public void RAdd(Resources_Requirements resourcesRequirements)
        {
            var xml = CollectionToSqlXml<ResourcesRequirements>(resourcesRequirements.Resourcesinput);
            StartProccess(xml, resourcesRequirements);
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


        /// <summary>
        /// 发起离职审批流程
        /// </summary>
        /// <param name="model"></param>
        [HttpPost, Route("api/atratleave")]
        public void atratleave(PlanAll model)
        {
            var xml = CollectionToSqlXml<Departure>(model.PlanDate);
            StartProccess(xml, model);
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
        /// 固定资产资料借用
        /// </summary>
        /// <param name="Loanrequest"></param>
        [HttpPost, Route("api/Loanrequest")]
        public void Loanrequest(Loanrequests oanrequest)
        {
            var xml = CollectionToSqlXml<Loanrequests>(oanrequest.loanrequests);
            StartProccess(xml,oanrequest);
        }

        /// <summary>
        /// 固定资产购置申请
        /// </summary>
        /// <param name="Acquisitionassets"></param>
        [HttpPost, Route("api/Acquisitionassets")]
        public void Acquisitionassets(Acquisition_assets cquisitionassets)
        {
            var xml = CollectionToSqlXml<Acquisitionassets>(cquisitionassets.acquisitionassets);
            StartProccess(xml,cquisitionassets);
        }

        /// <summary>
        /// 固定资产交接
        /// </summary>
        /// <param name="Connect"></param>
        [HttpPost, Route("api/Connect")]
        public void Connect(Connects connect)
        {
            var xml = CollectionToSqlXml<Connect>(connect.connect);
            StartProccess(xml,connect);
        }

        /// <summary>
        /// 发起离职交接流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/StartHandOver")]
        public void StartHandOver(PlanAll model)
        {
            var xml = CollectionToSqlXml<HandOver>(model.PlanDate);
            StartProccess(xml, model);
        }

        /// <summary>
        /// 发起用车申请流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/StartCarapply")]
        public void StartCarapply(PlanAll model)
        {
            var xml = CollectionToSqlXml<Carapply>(model.PlanDate);
            StartProccess(xml, model);
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
