using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT__Domain.outPutmodel
{
    public class outputmodels
    {
        public int StepID { get; set; }
        public int TaskID { get; set; }
        /// <summary>
        /// 流程名字
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        /// 判断是否有得审批的流程
        /// </summary>
        public string OwnerAccount { get; set; }
        /// <summary>
        /// 发起人账户
        /// </summary>
        public string OwnerAccounts { get; set; }
        /// <summary>
        /// 判断流程是否被审批
        /// </summary>
        public string SelAction { get; set; }
        /// <summary>
        /// 流程单号
        /// </summary>
        public string SerialNum { get; set; }
        /// <summary>
        /// 流程状态
        /// </summary>
        public string State { get; set; }
    }
}
