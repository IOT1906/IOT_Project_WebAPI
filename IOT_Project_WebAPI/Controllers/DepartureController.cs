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
    /// 离职服务器
    /// </summary>
    [ApiController]
    public class DepartureController : ControllerBase
    {
        private IConfiguration configuration;
        private readonly DepartureIServices _Dep;
        public DepartureController(DepartureIServices Dep, IConfiguration configuration)
        {
            _Dep = Dep;
            this.configuration = configuration;
        }
        
        [HttpPost, Route("api/StartLeave")]
        public void StartLeave(Departure Dep)
        {
            StartProccess<Departure>(Dep);
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

