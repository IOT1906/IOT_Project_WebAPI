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

    public class AcquisitionassetsServices : AcquisitionassetsIServices
    {
        /// <summary>
        /// 继承固定资产购置申请服务接口
        /// </summary>
        private readonly IRepository<Acquisitionassets> db;
        public AcquisitionassetsServices(IRepository<Acquisitionassets> _db)
        {
            this.db = _db;
        }

        public int Ladd(Acquisitionassets A)
        {
            return db.Add(A);
        }
    }
}
