using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
   public  interface MeetIServices
    {
        /// <summary>
        /// 新增会议室服务接口
        /// </summary>
        /// <param name="meeting"></param>
        /// <returns></returns>
        int MeetAdd(Meeting meeting);
    }
}
