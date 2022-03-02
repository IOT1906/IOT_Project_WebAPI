using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    ///员工离职面谈表
    /// </summary>
    public class Interview
    {
       [Key]
        /// <summary>
        ///员工离职面谈表—— TnterviewId
        /// </summary>
        public int TnterviewId { get; set; }
        /// <summary>
        ///员工离职面谈表—— TaskId
        /// </summary>
        public int TaskId { get; set; }


        /// <summary>
        ///员工离职面谈表—— 制表人
        /// </summary>
        public string InterviewLister { get; set; }
        /// <summary>
        ///员工离职面谈表—— 制表人
        /// </summary>
        public string InterviewListerDemp { get; set; }

        /// <summary>
        ///员工离职面谈表—— 制表日期
        /// </summary>
        public string InterviewListerDate { get; set; }
        /// <summary>
        ///员工离职面谈表—— 员工姓名
        /// </summary>
        public string InterviewStaffName { get; set; }
        /// <summary>
        ///员工离职面谈表—— 员工工号
        /// </summary>
        public string InterviewStaffNumber { get; set; }
        /// <summary>
        ///员工离职面谈表—— 所在部门
        /// </summary>
        public string InterviewDepartment { get; set; }
        /// <summary>
        ///员工离职面谈表—— 岗位
        /// </summary>
        public string InterviewStaion { get; set; }
        /// <summary>
        ///员工离职面谈表—— 入职日期
        /// </summary>
        public string InterviewStarDate { get; set; }
        /// <summary>
        ///员工离职面谈表—— 离职日期
        /// </summary>
        public string InterviewEndDate { get; set; }
        /// <summary>
        ///员工离职面谈表—— 劳动合同终止类型
        /// </summary>
        public string InterviewLabor { get; set; }
        /// <summary>
        ///员工离职面谈表—— 劳动合同终止原因
        /// </summary>
        public string InterviewCase { get; set; }
        /// <summary>
        ///员工离职面谈表—— 离职原因
        /// </summary>
        public string InterviewLeaving { get; set; }
        /// <summary>
        ///员工离职面谈表—— 面谈记录
        /// </summary>
        public string InterviewRecord { get; set; }




        /// <summary>
        ///员工离职面谈表—— 薪资和福利
        /// </summary>
        public string InterviewPay { get; set; }
        /// <summary>
        ///员工离职面谈表—— 培训发展
        /// </summary>
        public string InterviewTrain { get; set; }
        /// <summary>
        ///员工离职面谈表—— 提升前景
        /// </summary>
        public string InterviewProspect { get; set; }
        /// <summary>
        ///员工离职面谈表—— 公司管理
        /// </summary>
        public string InterviewCompany { get; set; }
        /// <summary>
        ///员工离职面谈表—— 奖励和认可
        /// </summary>
        public string InterviewAward { get; set; }
        /// <summary>
        ///员工离职面谈表—— 沟通渠道
        /// </summary>
        public string InterviewChnnel { get; set; }
        /// <summary>
        ///员工离职面谈表—— 工作满意度
        /// </summary>
        public string InterviewSatisfaction { get; set; }
        /// <summary>
        ///员工离职面谈表—— 员工和经理沟通
        /// </summary>
        public string InterviewManage { get; set; }
        /// <summary>
        ///员工离职面谈表—— 原因被公司重新录用
        /// </summary>
        public string InterviewEmploy { get; set; }
        /// <summary>
        ///员工离职面谈表—— 备注
        /// </summary>
        public string InterviewRemark { get; set; }

    }
}
