using Api.Controllers;
using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.InputModel;
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
    /// 人力资源控制器
    /// </summary>
    [ApiController]
    public class ResourcesRequirementsController : BaseController
    {
       
        public ResourcesRequirementsController(IConfiguration configuration) :base(configuration)
        {
        }

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


    }
}
