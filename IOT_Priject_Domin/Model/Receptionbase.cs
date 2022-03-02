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
    /// 接待申请表
    /// </summary>
    public class Receptionbase 
    {
        [Key]
        public int ReceId { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 接待申请表——申请人
        /// </summary>
        public string Receapplicant { get; set; }
        /// <summary>
        /// 接待申请表——申请部门
        /// </summary>
        public string Recedepartment { get; set; }
        /// <summary>
        /// 接待申请表——申请时间
        /// </summary>
        public string Recetime { get; set; }
        /// <summary>
        /// 接待申请表——来访客人单位
        /// </summary>
        public string Recevisitors { get; set; }
        /// <summary>
        /// 接待申请表——主要客人姓名职位
        /// </summary>
        public string Recemain { get; set; }
        /// <summary>
        /// 接待申请表——停留时间
        /// </summary>
        public string Recestay { get; set; }
        /// <summary>
        /// 接待申请表——结束时间（至)
        /// </summary>
        public string Recethe { get; set; }
        /// <summary>
        /// 接待申请表——接待人
        /// </summary>
        public string Receunawares { get; set; }
        /// <summary>
        /// 接待申请表——人数
        /// </summary>
        public string Recenumber { get; set; }
        /// <summary>
        /// 接待申请表——是否需要准备材料
        /// </summary>
        public string Receneed { get; set; }
        /// <summary>
        /// 接待申请表——航班号
        /// </summary>
        public string ReceFlight { get; set; }
        /// <summary>
        /// 接待申请表——是否需要物品
        /// </summary>
        public string Receitems { get; set; }
        /// <summary>
        /// 接待申请表——来访事由
        /// </summary>
        public string ReceVisiting { get; set; }
        /// <summary>
        /// 接待申请表——其他要求
        /// </summary>
        public string Recerequirements { get; set; }
        /// <summary>
        /// 接待申请表——备注
        /// </summary>
        public string Recenote { get; set; }
    }
}
