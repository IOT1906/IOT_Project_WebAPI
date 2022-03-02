using Api.Controllers;
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
    public class wedController : BaseController
    {
        public wedController(IConfiguration configuration):base(configuration)
        {

        }
        [HttpPost, Route("api/atratleave")]
        public void atratleave(PlanAll model)
        {
            var xml = CollectionToSqlXml<Departure>(model.PlanDate);
            StartProccess(xml,model);
        }
    }
}
