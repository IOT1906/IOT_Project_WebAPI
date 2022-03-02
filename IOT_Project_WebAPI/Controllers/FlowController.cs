using BPMAPI.OtherApi;
using bpmdemoapi.models;

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
        private IConfiguration configuration;
        public FlowController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public FlowController(IConfiguration configuration) : base(configuration)
        {
             StartProccess<ResourcesRequirements>(resourcesRequirements);

          
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
        /// <summary>
        /// 获取table
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private DataSet GetDataSet(Object data)
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
        //
        private Task<int> StartProccess<T>(T leaveNew) where T : BaseModels, new()
        {
            string formDataSet = ConvertXML.ConvertDataSetToXML(GetDataSet(leaveNew));
            BPMModels models = new BPMModels(configuration)
            {
                Action = leaveNew.Action,

                BPMUser = leaveNew.BPMUser,
                BPMUserPass = leaveNew.BPMUserPass,
                FormDataSet = formDataSet,
                FullName = leaveNew.FullName,
                ProcessName = leaveNew.ProcessName
            };
            return new MyClientApi().OptClientApi(models.BpmServerUrl, models);
        }
    }
}
