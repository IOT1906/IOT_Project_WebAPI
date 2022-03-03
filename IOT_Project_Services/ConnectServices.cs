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

    public class ConnectServices : ConnectIServices
    {
        /// <summary>
        /// 继承固定资产交接表服务接口
        /// </summary>
        private readonly IRepository<Connect> db;
        public ConnectServices(IRepository<Connect> _db) 
        {
            this.db = _db;
        }
        public int Ladd(Connect C)
        {
            return db.Add(C);
        }
    }
}
