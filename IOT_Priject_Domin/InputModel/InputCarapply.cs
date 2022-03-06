using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
    /// <summary>
    /// 用车申请表
    /// </summary>
    public class InputCarapply: BaseModels
    {
        [Key]
        /// <summary>
        /// 用车申请表——Id
        /// </summary>
        public int CarapplyId { get; set; }
        /// <summary>
        /// 用车申请表——TaskId
        /// </summary>
        public int TaskId { get; set; }


        /// <summary>
        /// 用车申请表——申请人
        /// </summary>
        public string CarapplyProposer { get; set; }
        /// <summary>
        /// 用车申请表——申请部门
        /// </summary>
        public string CarapplyTProposerDemp { get; set; }
        /// <summary>
        /// 用车申请表——申请时间
        /// </summary>
        public string CarapplyProposerDate { get; set; }
        /// <summary>
        /// 用车申请表——星期
        /// </summary>
        public string CarapplyWeek { get; set; }
        /// <summary>
        /// 用车申请表——出发地点
        /// </summary>
        public string CarapplyDepart { get; set; }
        /// <summary>
        /// 用车申请表——目标地点
        /// </summary>
        public string CarapplyTarget { get; set; }
        /// <summary>
        /// 用车申请表——出发时间
        /// </summary>
        public string CarapplyStartDate { get; set; }
        /// <summary>
        /// 用车申请表——返回时间
        /// </summary>
        public string CarapplyEndDate { get; set; }
        /// <summary>
        /// 用车申请表——乘车人员
        /// </summary>
        public string CarapplyRiding { get; set; }
        /// <summary>
        /// 用车申请表——随同人员
        /// </summary>
        public string CarapplyCommon { get; set; }
        /// <summary>
        /// 用车申请表——事由
        /// </summary>
        public string CarapplyReason { get; set; }
        /// <summary>
        /// 用车申请表——车牌号
        /// </summary>
        public string CarapplyPlate { get; set; }
        /// <summary>
        /// 用车申请表——出发时间
        /// </summary>
        public string CarapplyDeparture { get; set; }
        /// <summary>
        /// 用车申请表——途径
        /// </summary>
        public string CarapplyApproach { get; set; }
        /// <summary>
        /// 用车申请表——出发表盘公里数
        /// </summary>
        public string CarapplyKilometre { get; set; }
        /// <summary>
        /// 用车申请表——结束表盘公里数
        /// </summary>
        public string CarapplyFinish { get; set; }
        /// <summary>
        /// 用车申请表——实际公里数
        /// </summary>
        public string CarapplyPractical { get; set; }
        /// <summary>
        /// 用车申请表——驾驶员
        /// </summary>
        public string CarapplyDriver { get; set; }
        /// <summary>
        /// 用车申请表——备注
        /// </summary>
        public string CarapplyRemark { get; set; }
    }
}
