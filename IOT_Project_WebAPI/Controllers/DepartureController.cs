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
        private readonly DepartureIServices _sql;

        public DepartureController(DepartureIServices sql)
        {
            _sql = sql;
        }
        /// <summary>
        /// 离职提交方法
        /// </summary>
        /// <param name="departure"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DepAdd")]
        public IActionResult DepAdd(Departure departure)
        {
            var list = _sql.DepAdd(departure);
            return Ok(list);
        }
    }
}
