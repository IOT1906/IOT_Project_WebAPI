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
    /// 人力资源控制器
    /// </summary>
    [ApiController]
    public class ResourcesRequirementsController : ControllerBase
    {
        private readonly ResourcesRequirementsIServices db;
        private IConfiguration configuration;
        public ResourcesRequirementsController(ResourcesRequirementsIServices _db,IConfiguration _configuration) 
        {
            this.db = _db;
            this.configuration = _configuration;
        }
        /// <summary>
        /// 人力资源申请方法
        /// </summary>
        /// <param name="R"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Radd")]
        public ActionResult Radd(ResourcesRequirements R) 
        {
            return Ok(db.Radd(R));
        }

        /// <summary>
        /// 发起请假流程
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/RAdd")]
        public void RAdd(ResourcesRequirements resourcesRequirements)
        {
            StartProccess<ResourcesRequirements>(resourcesRequirements);
        }

        /// <summary>
        /// 获取table
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static DataSet GetDataSet(Object data)
        {
            Type type = data.GetType();


            DataSet formDataSet = new DataSet("FormData");


            DataTable table = new DataTable(type.Name);
            string IsNotField = "Action,BPMUser,BPMUserPass,FullName,ProcessName";
            foreach (var property in type.GetProperties())
            {


                if (!IsNotField.Contains(property.Name))
                    table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
            }
            DataRow add_row = table.NewRow();
            foreach (var property in type.GetProperties())
            {
                if (!IsNotField.Contains(property.Name))
                    add_row[property.Name] = property.GetValue(data);
            }
            table.Rows.Add(add_row);
            formDataSet.Tables.Add(table);
            return formDataSet;
        }


        [HttpPost]
        [Route("api/stratBPM")]
        public Task<int> StartProccess<T>(T leave) where T : BaseModels, new()
        {
            string formDataSet = ConvertXML.ConvertDataSetToXML(GetDataSet(leave));
            BPMModels models = new BPMModels(configuration)
            {
                Action = leave.Action,


                BPMUser = leave.BPMUser,
                BPMUserPass = leave.BPMUserPass,
                FormDataSet = formDataSet,
                FullName = leave.FullName,
                ProcessName = leave.ProcessName
            };
            return MyClientApi.OptClientApi(models.BpmServerUrl, models);
        }

    }
}
