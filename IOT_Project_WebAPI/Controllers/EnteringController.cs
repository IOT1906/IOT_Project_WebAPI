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
    /// 员工录入控制器
    /// </summary>
    [ApiController]
    public class EnteringController : ControllerBase
    {
        private EnteringIServices db;
        public EnteringController(EnteringIServices _db)
        {
            db = _db;
        }
        [HttpGet]
        [Route("api/bind")]
        public ActionResult bind()
        {
           return Ok(db.bind());
        }
        [HttpGet]
        [Route("api/getbind")]
        public ActionResult getbind(int id)
        {
            return Ok(db.getbind(id));
        }
    }
}
