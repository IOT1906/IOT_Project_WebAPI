using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    public interface AcceptanceIServices
    {
        /// <summary>
        /// 固定资产验收表
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        int Aadd(Assetacceptance A);
        /// <summary>
        /// 固定资产验收表
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        int Badd(AcceptanceDetails B);
        /// <summary>
        /// 固定资产验收表
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        int Cadd(Acceptanceannex C);
    }
}
