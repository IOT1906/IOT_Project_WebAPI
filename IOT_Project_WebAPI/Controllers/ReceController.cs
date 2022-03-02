using Api.Controllers;
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
    public class ReceController : BaseController
    {
        public ReceController(IConfiguration configuration):base(configuration)
        {

        }
        [HttpPost, Route("api/Receleave")]
        public void Receleave(ReceAll model)
        {
            var xml = CollectionToSqlXml<ReceItemDetails>(model.ReceItemDetails);
            var xmls = CollectionToSqlXml<ReceItineraryDetails>(model.ReceItineraryDetails);
            var xmlss = CollectionToSqlXml<Receptionbase>(model.Receptionbase);
            StartProccess(xml+xmls+xmlss, model);
        }




    }
}
