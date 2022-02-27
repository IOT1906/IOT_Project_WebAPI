using IOT_Priject_Domin.Model;
using IOT_Project_IServices;
using IOT_Project_Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Project_WebAPI.Controllers
{
    /// <summary>
    /// 年度计划控制器
    /// </summary>
    [ApiController]
    public class Annual_PlanController : ControllerBase
    {
        private readonly Annual_PlanIServices _Year;
        public Annual_PlanController(Annual_PlanIServices Year)
        {
            _Year = Year;
        }
        /// <summary>
        /// 本年预计增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [HttpPost,Route("api/ExpectedAdd")]
        public int ExpectedAdd([FromBody]Expected_increase_this_year year)
        {
            return _Year.ExpectedAdd(year);
        }
        /// <summary>
        /// 年度计划添加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [HttpPost, Route("api/AnnualAdd")]
        public int AnnualAdd([FromBody] Annual_plan year)
        {
            return _Year.AnnualAdd(year);
        }

        

    }
}
