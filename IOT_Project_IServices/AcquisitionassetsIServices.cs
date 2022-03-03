using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    public interface AcquisitionassetsIServices
    {
        /// <summary>
        /// 固定资产购置申请表
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        int Ladd(Acquisitionassets A);
    }
}
