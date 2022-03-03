using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 日常用品采购申请单——详细信息
    /// </summary>
   public class Dailydetailed
    {
        [Key]
        public int Dailys { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 日常用品采购申请单——用品名称
        /// </summary>
        public string Daisserial { get; set; }
        /// <summary>
        /// 日常用品采购申请单——规格
        /// </summary>
        public string Daisname { get; set; }
        /// <summary>
        /// 日常用品采购申请单——数量
        /// </summary>
        public int Daisspecifications { get; set; }
        /// <summary>
        /// 日常用品采购申请单——单位
        /// </summary>
        public string Daisnumber { get; set; }
        /// <summary>
        /// 日常用品采购申请单——单价
        /// </summary>
        public int Daisunit { get; set; }
        /// <summary>
        /// 日常用品采购申请单——金额
        /// </summary>
        public string Daisprice { get; set; }
        /// <summary>
        /// 日常用品采购申请单——备注
        /// </summary>
        public string Daisnote { get; set; }


    }
}
