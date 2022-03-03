using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 接待申请表——物品详细信息
    /// </summary>
    public class ReceItemDetails
    {
        [Key]
        public int RecesId { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 接待申请表——物品名称
        /// </summary>
        public string RecesName { get; set; }
        /// <summary>
        /// 接待申请表——规格
        /// </summary>
        public string Recespecifications { get; set; }
        /// <summary>
        /// 接待申请表——使用数量
        /// </summary>
        public int Recesuse{ get; set; }
        /// <summary>
        /// 接待申请表——库存数量
        /// </summary>
        public int Recesinventory { get; set; }
        /// <summary>
        /// 接待申请表——剩余数量
        /// </summary>
        public int Recesremaining { get; set; }
        /// <summary>
        /// 接待申请表——备注
        /// </summary>
        public string Recesnote { get; set; }



    }
}
