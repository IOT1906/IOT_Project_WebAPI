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


    }
}
