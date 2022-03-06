using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.OutPutModel
{
    public class OutPutModels
    {
        /// <summary>
        /// TaskID
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// StepID
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        ///审批人
        /// </summary>
        public string OwnerAccount { get; set; }
        /// <summary>
        /// 继续或结束
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 同意不同意
        /// </summary>
        public string SelAction { get; set; }

    }
}
