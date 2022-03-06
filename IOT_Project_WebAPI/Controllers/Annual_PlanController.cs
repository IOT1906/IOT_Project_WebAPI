using Api.Controllers;
using BPMAPI.OtherApi;
using bpmdemoapi.models;
using IOT_Priject_Domin.InputModel;
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
    /// 年度计划控制器
    /// </summary>
    [ApiController]
    public class Annual_PlanController : BaseController
    {
        private readonly Annual_PlanIServices db;
        public Annual_PlanController(Annual_PlanIServices _db,IConfiguration configuration) : base(configuration)
        {
            db = _db;
        }
        /// <summary>
        /// 本年预计增加
        /// </summary>
        /// <param name = "year" ></ param >
        /// < returns ></ returns >
        [HttpPost,Route("api/ExpectedAdd")]
        public int ExpectedAdd(Expected_increase_this_year year)
        {
            return db.ExpectedAdd(year);
        }
        /// <summary>
        /// 年度计划增加
        /// </summary>
        /// <param name = "year" ></ param >
        /// < returns ></ returns >
        [HttpPost, Route("api/AnnualAdd")]
        public int AnnualAdd(Annual_plan year)
        {
            return db.AnnualAdd(year);
        }
        /// <summary>
        /// 公告基本信息增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [HttpPost, Route("api/NoticeAdd")]
        public int NoticeAdd(Notice tice)
        {
            return db.NoticeAdd(tice);
        }
        /// <summary>
        /// 文件管理增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [HttpPost, Route("api/ManagementAdd")]
        public int ManagementAdd(Management manage)
        {
            return db.ManagementAdd(manage);
        }
        /// <summary>
        /// 刻章申请增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [HttpPost, Route("api/EngraveAdd")]
        public int EngraveAdd(Engrave_chapter chapter)
        {
            return db.EngraveAdd(chapter);
        }
        /// <summary>
        /// 用章申请增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [HttpPost, Route("api/UseAdd")]
        public int UseAdd(Use_seal seal)
        {
            return db.UseAdd(seal);
        }



    }
}
