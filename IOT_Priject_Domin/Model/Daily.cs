using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 日常用品采购申请单
    /// </summary>
    public class Daily
    {
        [Key]
        public int DaiId { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 日常用品采购申请单——申请人
        /// </summary>
        public string Daiapplicant { get; set; }
        /// <summary>
        /// 日常用品采购申请单——经办人
        /// </summary>
        public string Daiagent { get; set; }
        /// <summary>
        /// 日常用品采购申请单——申请部门
        /// </summary>
        public string Daidepartment { get; set; }
        /// <summary>
        /// 日常用品采购申请单——经办部门
        /// </summary>
        public string DaiHandling { get; set; }
        /// <summary>
        /// 日常用品采购申请单——申请日期
        /// </summary>
        public string DaiApplication { get; set; }
        /// <summary>
        /// 日常用品采购申请单——经办日期
        /// </summary>
        public string Daidate { get; set; }
        /// <summary>
        /// 日常用品采购申请单——用途
        /// </summary>
        public string Daiuse { get; set; }
        /// <summary>
        /// 日常用品采购申请单——备注
        /// </summary>
        public string Dainote { get; set; }


    }
}
