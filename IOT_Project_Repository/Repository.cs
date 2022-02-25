using IOT_Project_IRepository;
using IOT_Project_MyDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly MyDbContext db;

        public Repository(MyDbContext db)
        {
            this.db = db;
        }
        /// <summary>
        /// 泛型添加操作
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public int Add(T mode)
        {
            db.Set<T>().Add(mode);
            return db.SaveChanges();
        }
        /// <summary>
        /// 泛型单条数据获取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>6
        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }
        /// <summary>
        /// 泛型数据显示操作
        /// </summary>
        /// <returns></returns>
        public List<T> Show()
        {
            return db.Set<T>().AsQueryable().ToList();
        }
    }
}
