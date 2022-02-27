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
    public class DepartureServices : DepartureIServices
    {
        private readonly IRepository<Departure> _Dep;
        public DepartureServices(IRepository<Departure> Dep)
        {
            _Dep = Dep;
        }
        public int DepAdd(Departure Del)
        {
            return _Dep.Add(Del);
        }
    }
}
