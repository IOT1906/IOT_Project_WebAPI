using IOT_Priject_Domin.InputModel;
using IOT_Project_IRepository;
using IOT_Project_IServices;
using IOT_Project_MyDB;
using System.Collections.Generic;
using System.Linq;

namespace IOT_Project_Services
{
    // <summary>
    /// 继承员工录入接口
    /// </summary>
    public class EnteringServices : EnteringIServices
    {
        /// <summary>
        /// 使用角色表
        /// </summary>
        /// <summary>
        /// 使用部门表调用仓储
        /// </summary>
        private MyDbContext db;
        private IRepository<BPMSysOUs> depat;
        public EnteringServices(IRepository<BPMSysOUs> _depat, MyDbContext _db)
        {
            depat = _depat;
            db = _db;
        }
        /// <summary>
        /// 绑定部门表
        /// </summary>
        /// <returns></returns>
        public List<BPMSysOUs> bind()
        {
            var ss= depat.Show();
            return ss;
        }



        public List<BPMSysOURoles> getbind(int id)
        {

            var ss = (from s in db.BPMSysOURoles select s).ToList().Distinct().ToList();
            //  var ss= db.BPMSysOURoles.ToList();
            if (id != 0)
            {
                ss = ss.Where(x => x.OUID == id).ToList();
            }
            return ss;
        }
    }
}
