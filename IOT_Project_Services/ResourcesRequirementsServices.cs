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
    /// 继承人力资源需求申请服务接口
    /// </summary>
    public class ResourcesRequirementsServices: ResourcesRequirementsIServices
    {
        private readonly IRepository<ResourcesRequirements> db;
        public ResourcesRequirementsServices (IRepository<ResourcesRequirements> _db) 
        {
            this.db = _db;
        }
        public int Radd(ResourcesRequirements R)
        {
            return db.Add(R);
        }


    }
}
