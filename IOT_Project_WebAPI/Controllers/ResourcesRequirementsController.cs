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
    /// 人力资源控制器
    /// </summary>
    [ApiController]
    public class ResourcesRequirementsController : ControllerBase
    {
        private readonly ResourcesRequirementsIServices db;
        public ResourcesRequirementsController(ResourcesRequirementsIServices _db) 
        {
            this.db = _db;
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
    }
}
