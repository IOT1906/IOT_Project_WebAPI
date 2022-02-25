using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IRepository
{
  public  interface IRepository<T> where T:class,new()
    {
        /// <summary>
        /// 泛型添加操作
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        int Add(T mode);
        /// <summary>
        /// 泛型数据显示操作
        /// </summary>
        /// <returns></returns>
        List<T> Show();
        /// <summary>
        /// 泛型单条数据获取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);
    }
}
