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
    public class MeetServices: MeetIServices
    {
        /// <summary>
        /// 会议新增表
        /// </summary>
        /// <summary>
        /// 使用会议新增表
        private readonly IRepository<Meeting> _sql;

        public MeetServices(IRepository<Meeting> sql)
        {
            _sql = sql;
        }
        /// <summary>
        /// 会议室新增服务
        /// </summary>
        /// <param name="meeting"></param>
        /// <returns></returns>

        public int MeetAdd(Meeting meeting)
        {
            return _sql.Add(meeting);
        }

        


    }
}
