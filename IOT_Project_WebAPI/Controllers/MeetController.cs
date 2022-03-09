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
    /// 会议室新增
    /// </summary>
    [ApiController]
    public class MeetController : ControllerBase
    {
        /// <summary>
        /// 注入MeetIServices服务上下文
        /// </summary>
        private readonly MeetIServices _db;
        public MeetController(MeetIServices db)
        {
            _db = db;
        }
        /// <summary>
        /// 新增会议室方法
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("api/MeetAdd")]
        public IActionResult MeetAdd(Meeting meeting)
        {
            return Ok(_db.MeetAdd(meeting));
        }

    }
}
