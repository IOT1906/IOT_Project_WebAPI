using IOT_Priject_Domin.Model;
using IOT_Project_IRepository;
using IOT_Project_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_Services
{
    // <summary>
    /// 继承请假申请服务接口
    /// </summary>
    public class LeaveServices : LeaveIservices
    {
        private readonly IRepository<Leave> db;
        public LeaveServices(IRepository<Leave> db)
        {
            this.db = db;
        }
        ///// <summary>
        ///// 请假提交申请
        ///// </summary>
        ///// <param name="mode"></param>
        ///// <returns></returns>
        //public int Add(Leave mode)
        //{
        //    return db.Add(mode);
        //}
    }
}
