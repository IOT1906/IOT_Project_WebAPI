using IOT_Priject_Domin.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    /// <summary>
    /// 员工录入服务接口
    /// </summary>
    public interface EnteringIServices
    {
        /// <summary>
        /// 绑定部门
        /// </summary>
        /// <returns></returns>
        List<BPMSysOUs> bind();
        /// <summary>
        /// 绑定岗位
        /// </summary>
        /// <returns></returns>
        List<BPMSysOURoles> getbind(int id);
    }
}
