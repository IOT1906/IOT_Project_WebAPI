using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    /// <summary>
    /// 员工离职服务申请
    /// </summary>
    public interface DepartureIServices
    {
        /// <summary>
        /// 离职方法
        /// </summary>
        /// <param name="departure"></param>
        /// <returns></returns>
        int DepAdd(Departure departure);
    }
}
