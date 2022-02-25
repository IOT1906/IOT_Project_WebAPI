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
    /// <summary>
    /// 继承员工离职服务接口
    /// </summary>
    public class DepartureServices: DepartureIServices
    {
        private readonly IRepository<Departure> _Deps;
        public DepartureServices(IRepository<Departure> Deps)
        {
            _Deps = Deps;
        }
        /// <summary>
        /// 离职提交方法
        /// </summary>
        /// <param name="departure"></param>
        /// <returns></returns>
        public int DepAdd(Departure departure)
        {
            return _Deps.Add(departure);
        }
    }
}
