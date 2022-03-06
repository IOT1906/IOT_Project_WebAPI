using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 附件详细信息
    /// </summary>
    public class Acceptanceannex
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 附件说明
        /// </summary>
        public string Attachmentdescription { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string Quantity { get; set; }
        /// <summary>
        /// 保管人
        /// </summary>
        public string Custodian { get; set; }
    }
}
