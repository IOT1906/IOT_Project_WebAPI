using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    /// <summary>
    /// 人力资源需求申请服务接口
    /// </summary>
    public interface ResourcesRequirementsIServices
    {
        /// <summary>
        /// 人力资源添加方法
        /// </summary>
        /// <param name="R"></param>
        /// <returns></returns>
        int Radd(ResourcesRequirements R);


    }
}
