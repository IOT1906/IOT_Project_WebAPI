using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    /// <summary>
    /// 请假申请服务接口
    /// </summary>
    public interface LeaveIservices
    {
        /// <summary>
        /// 泛型添加操作
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        int Add(Interview mode);
    }
}
