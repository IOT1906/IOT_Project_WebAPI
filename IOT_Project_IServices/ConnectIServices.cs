using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    public interface ConnectIServices
    {
        /// <summary>
        /// 固定资产交接表
        /// </summary>
        /// <param name="C"></param>
        /// <returns></returns>
        int Ladd(Connect C);
    }
}
