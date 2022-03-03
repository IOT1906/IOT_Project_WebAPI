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


    }
}
