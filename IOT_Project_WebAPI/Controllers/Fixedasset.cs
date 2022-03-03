using BPMAPI.OtherApi;
using bpmdemoapi.models;
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
    /// 固定资产控制器
    /// </summary>
    [ApiController]
    public class Fixedasset : ControllerBase
    {
        private readonly LoanrequestIServices db;
        private IConfiguration configuration;
        public Fixedasset(LoanrequestIServices _db, IConfiguration _configuration)
        {
            this.db = _db;
            this.configuration = _configuration;
        }

        /// <summary>
        /// 固定资产资料借用
        /// </summary>
        /// <param name="Loanrequest"></param>
        [HttpPost, Route("api/Loanrequest")]
        public void Loanrequest(Loanrequest loanrequest)
        {
            StartProccess<Loanrequest>(loanrequest);
        }

        /// <summary>
        /// 固定资产购置申请
        /// </summary>
        /// <param name="Acquisitionassets"></param>
        [HttpPost, Route("api/Acquisitionassets")]
        public void Acquisitionassets(Acquisitionassets acquisitionassets)
        {
            StartProccess<Acquisitionassets>(acquisitionassets);
        }

        /// <summary>
        /// 固定资产交接
        /// </summary>
        /// <param name="Connect"></param>
        [HttpPost, Route("api/Connect")]
        public void Connect(Connect connect)
        {
            StartProccess<Connect>(connect);
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
