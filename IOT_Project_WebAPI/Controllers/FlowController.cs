﻿using BPMAPI.OtherApi;
using bpmdemoapi.models;

using IOT_Priject_Domin.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Threading.Tasks;

/// <summary>
/// 流程控制器
/// </summary>
namespace Project.Controllers
{
    [ApiController]
    public class FlowController :ControllerBase
    {
        private IConfiguration configuration;
        public FlowController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// 发起人力资源
        /// </summary>
        /// <param name="ResourcesRequirements"></param>
        [HttpPost, Route("api/Add")]
        public void Add([FromBody]ResourcesRequirements resourcesRequirements)
        {
             StartProccess<ResourcesRequirements>(resourcesRequirements);

          
        }
        /// <summary>
        /// 发起流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/startdeparture")]
        public void StartLeave(Departure departure)
        {
            StartProccess<Departure>(departure);
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
