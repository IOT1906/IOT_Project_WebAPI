using IOT_Priject_Domin.InputModel;
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
    /// 继承年度计划服务接口
    /// </summary>
    public class Annual_PlanServices:Annual_PlanIServices
    {
        private readonly IRepository<Annual_plan> _annual;
        private readonly IRepository<Expected_increase_this_year> _Year;
        private readonly IRepository<Engrave_chapter> _engrave;
        private readonly IRepository<Notice> _db;
        private readonly IRepository<Use_seal> _dh;
        private readonly IRepository<Management> _da;
        public Annual_PlanServices(IRepository<Management> da,IRepository<Use_seal> dh,IRepository<Notice> db,IRepository<Engrave_chapter> engrave,IRepository<Annual_plan> annual, IRepository<Expected_increase_this_year> Year)
        {
            _engrave = engrave;
            _da = da;
            _dh = dh;
            _db = db;
            _annual = annual;
            _Year = Year;
        }
        /// <summary>
        /// 本年预计增加
        /// </summary>
        /// <param name = "year" ></ param >
        /// < returns ></ returns >
        public int ExpectedAdd(Expected_increase_this_year year)
        {
            return _Year.Add(year);
        }
        /// <summary>
        /// 年度计划增加
        /// </summary>
        /// <param name = "year" ></ param >
        /// < returns ></ returns >
        public int AnnualAdd(Annual_plan year)
        {
            return _annual.Add(year);
        }
        /// <summary>
        /// 公告基本信息增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int NoticeAdd(Notice tice)
        {
            return _db.Add(tice);
        }
        /// <summary>
        /// 文件管理增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int ManagementAdd(Management manage)
        {
            return _da.Add(manage);
        }
        /// <summary>
        /// 刻章申请增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int EngraveAdd(Engrave_chapter chapter)
        {
            return _engrave.Add(chapter);
        }
        /// <summary>
        /// 用章申请增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int UseAdd(Use_seal seal)
        {
            return _dh.Add(seal);
        }
    }
}
