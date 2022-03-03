using IOT_Priject_Domin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_IServices
{
    public interface LoanrequestIServices
    {
        /// <summary>
        /// 固定资产资料借用表
        /// </summary>
        /// <param name="L"></param>
        /// <returns></returns>
        int Ladd(Loanrequest L);
    }
}
