using Api.Controllers;
using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.InputModel;
using IOT_Priject_Domin.InputModels;
using IOT_Priject_Domin.Model;
using IOT_Project_MyDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1;


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
        /// 发起请假流程/
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
        /// </summary>resourcesinput
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
        /// 审批流程
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/Startag")]
        public void Startag(chooseinput annual)
        {
            StartAudit(annual);
        }
        /// <summary>
        /// 拒绝流程
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/StartagNO")]
        public void StartagNO(TaskModel annual)
        {
            NoProccess(annual);
        }
        /// <summary>
        /// 发起离职审批流程
        /// </summary>
        /// <param name="model"></param>
        [HttpPost, Route("api/atratDep")]
        public void atratDep(PlanAll model)
        {
            var xml = CollectionToSqlXml<Departure>(model.PlanDate);
            StartProccess(xml, model);
        }



        /// <summary>
        /// 同意
        /// </summary>
        /// <param name="Stp"></param>
        [HttpPost, Route("api/StepatratDep")]
        public void StepatratDep(StepModels Stp)
        {
            yesProccess(Stp);
        }
        /// <summary>
        /// 拒绝
        /// </summary>
        /// <param name="Stp"></param>
        [HttpPost, Route("api/TaskDep")]
        public void TaskDep(TaskModel Tasks)
        {
            NoProccess(Tasks);
        }







        //二周流程发起

        /// <summary>
        /// 发起接待表单流程
        /// </summary>
        /// <param name="model"></param>

        [HttpPost, Route("api/Reception")]
        public void Reception(ReceAll model)
        {
            var xml = CollectionToSqlXml<ReceItemDetails>(model.ReceItemDetails);
            var xmls = CollectionToSqlXml<ReceItineraryDetails>(model.ReceItineraryDetails);
            var xmlss = CollectionToSqlXml<Receptionbase>(model.Receptionbase);
            StartProccess(xmlss + xmls + xml, model);
        }

        /// <summary>
        /// 固定资产资料借用
        /// </summary>
        /// <param name="Loanrequest"></param>
        [HttpPost, Route("api/Loanrequest")]
        public void Loanrequest(Loanrequests oanrequest)
        {
            var xml = CollectionToSqlXml<Loanrequest>(oanrequest.loanrequests);
            StartProccess(xml, oanrequest);
        }
        /// <summary>
        /// 固定资产验收
        /// </summary>
        /// <param name="Loanrequest"></param>
        [HttpPost, Route("api/Assetacceptance")]
        public void Assetacceptance(AsseAll oanrequest)
        {
            var xml = CollectionToSqlXml<Assetacceptance>(oanrequest.Assetacceptance);
            var xmla = CollectionToSqlXml<AcceptanceDetails>(oanrequest.AcceptanceDetails);
            var xmlc = CollectionToSqlXml<Acceptanceannex>(oanrequest.Acceptanceannex);
            StartProccess(xml+xmla+xmlc, oanrequest);
        }
        /// <summary>
        /// 固定资产购置申请
        /// </summary>
        /// <param name="Acquisitionassets"></param>
        [HttpPost, Route("api/Acquisitionassets")]
        public void Acquisitionassets(Acquisition_assets cquisitionassets)
        {
            var xml = CollectionToSqlXml<Acquisitionassets>(cquisitionassets.acquisitionassets);
            StartProccess(xml, cquisitionassets);
        }

        /// <summary>
        /// 固定资产交接
        /// </summary>
        /// <param name="Connect"></param>
        [HttpPost, Route("api/Connect")]
        public void Connect(Connects connect)
        {
            var xml = CollectionToSqlXml<Connect>(connect.connect);
            StartProccess(xml, connect);
        }
        /// <summary>
        /// 固定资产交接审批
        /// </summary>
        /// <param name="Connect"></param>
        [HttpPost, Route("api/Connectsp")]
        public void Connectsp(chooseinput baseModels)
        {
            StartPs(baseModels);
        }
        /// <summary>
        /// 固定资产交接驳回
        /// </summary>
        /// <param name="Connect"></param>
        [HttpPost, Route("api/Connectbh")]
        public void Connectbh(TaskModel baseModels)
        {
            BoProccess(baseModels);
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
        /// 日常用品采购申请单
        /// </summary>
        /// <param name="daily"></param>
        [HttpPost, Route("api/evertion")]
        public void evertion(EvetAll daily)
        {
            var xml = CollectionToSqlXml<Daily>(daily.Daily);
            var xmls = CollectionToSqlXml<Dailydetailed>(daily.Dailydetailed);
            StartProccess(xml + xmls, daily);





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

        ////[HttpPost, Route("api/Uptimg")]
        //public string Uptimg()
        //{
        //    var file = HttpContext.Current.Request.Files[0];
        //    string ss = file.FileName;
        //    var arr = file.FileName.Substring(ss.IndexOf('.'), ss.Length - ss.IndexOf('.'));
        //    ss = DateTime.Now.ToString("yyyyMMddhhmmss") + arr;
        //    file.SaveAs(HttpContext.Current.Server.MapPath("`/img/`") + ss);
        //    return ss;
        //}
        //[HttpPost]
        //public async Task<IActionResult> PostAsync(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);

        //    foreach (var formFile in files)
        //    {
        //        var filePath = @"D:\img\" + formFile.FileName;

        //        if (formFile.Length > 0)
        //        {
        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }
        //        }
        //    }

        //    return Ok(new { count = files.Count, size });
        //}

    }   
} 