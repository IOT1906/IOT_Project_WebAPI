using IOT_Priject_Domin.InputModel;
using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    /// <summary>
    /// 年度计划服务接口
    /// </summary>
    public interface Annual_PlanIServices
    {
        
        /// <summary>
        /// 本年预计增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        int ExpectedAdd(Expected_increase_this_year year);
        /// <summary>
        /// 年度计划增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        int AnnualAdd(Annual_plan year);
        /// <summary>
        /// 公告基本信息增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        int NoticeAdd(Notice tice);
        /// <summary>
        /// 文件管理增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        int ManagementAdd(Management manage);
        /// <summary>
        /// 刻章申请增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        int EngraveAdd(Engrave_chapter chapter);
        /// <summary>
        /// 用章申请增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        int UseAdd(Use_seal seal);
    }
}
