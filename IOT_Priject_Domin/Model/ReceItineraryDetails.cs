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
    /// 接待申请表——行程信息
    /// </summary>
    public class ReceItineraryDetails 
    {
        [Key]
        public int RececId { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 接待申请表——开始时间
        /// </summary>
        public string Rececstart { get; set; }
        /// <summary>
        /// 接待申请表——结束时间
        /// </summary>
        public string Rececend { get; set; }
        /// <summary>
        /// 接待申请表——行程
        /// </summary>
        public string Recectrip { get; set; }
        /// <summary>
        /// 接待申请表——陪同人员
        /// </summary>
        public string RececAccompanied { get; set; }
        /// <summary>
        /// 接待申请表——是否用车
        /// </summary>
        public string Receccar { get; set; }
        /// <summary>
        /// 接待申请表——是否预定会议室
        /// </summary>
        public string Rececmeeting { get; set; }
        /// <summary>
        /// 接待申请表——是否预定酒店
        /// </summary>
        public string Recechotel { get; set; }
        /// <summary>
        /// 接待申请表——是否需要展厅
        /// </summary>
        public string Rececexhibition { get; set; }
        /// <summary>
        /// 接待申请表——参加公司是否需要订餐
        /// </summary>
        public string Rececmeal { get; set; }
        /// <summary>
        /// 接待申请表——参加公司部门
        /// </summary>
        public string Rececdepartment { get; set; }
        /// <summary>
        /// 接待申请表——备注
        /// </summary>
        public string Rececnote { get; set; }
    }
}
