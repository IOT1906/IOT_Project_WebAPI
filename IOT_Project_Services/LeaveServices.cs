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
    /// 继承员工面谈申请服务接口
    /// </summary>
    public class LeaveServices : LeaveIservices
    {
        private readonly IRepository<Interview> db;
        public LeaveServices(IRepository<Interview> db)
        {
            this.db = db;
        }
        /// <summary>
        /// 员工面谈提交申请
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public int Add(Interview mode)
        {
            return db.Add(mode);
        }
    }
}
