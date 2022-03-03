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
    /// 继承固定资产资料借用服务接口
    /// </summary>
    public class LoanrequestServices : LoanrequestIServices
    {
        private readonly IRepository<Loanrequest> db;
        public LoanrequestServices(IRepository<Loanrequest> _db)
        {
            this.db = _db;
        }

        public int Ladd(Loanrequest L)
        {
            return db.Add(L);
        }
    }
}
