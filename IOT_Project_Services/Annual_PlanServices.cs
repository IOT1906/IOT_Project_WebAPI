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
        private readonly IRepository<Expected_increase_this_year> _Year;
        private readonly IRepository<Annual_plan> _annual;
        public Annual_PlanServices(IRepository<Expected_increase_this_year> Year, IRepository<Annual_plan> annual)
        {
            _Year = Year;
            _annual = annual;
        }
        /// <summary>
        /// 本年预计增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int ExpectedAdd(Expected_increase_this_year year)
        {
            return _Year.Add(year);
        }
        /// <summary>
        /// 年度计划增加
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int AnnualAdd(Annual_plan year)
        {
            return _annual.Add(year);
        }




    }
}
