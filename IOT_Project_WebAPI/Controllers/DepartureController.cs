using IOT_Priject_Domin.Model;
using IOT_Project_IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        private readonly DepartureIServices _Dep;
        public DepartureController(DepartureIServices Dep)
        {
            _Dep = Dep;
        }
        [HttpPost]
        [Route("api/DepAdd")]
        public IActionResult DepAdd(Departure Dep)
        {
            return Ok(_Dep.DepAdd(Dep));
        }

    }
}
