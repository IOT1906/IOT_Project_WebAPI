﻿using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    
        /// <summary>
        /// 请假申请流程表
        /// </summary>
        public class Leave: BaseModels
    {
            [Key]
            /// <summary>
            /// Id
            /// <summary>
            public int Id { get; set; }
            /// <summary>
            /// TaskId
            /// </summary>
            public int TaskId { get; set; }
            /// <summary>
            /// 申请人-
            /// </summary>
            public string Proposer { get; set; }
            /// <summary>
            /// 申请部门
            /// </summary>
            public int ApplyDemo { get; set; }
            /// <summary>
            /// 申请时间
            /// </summary>
            public DateTime ApplyTime { get; set; }

            /// <summary>
            /// 请假类型
            /// </summary>
            public string LeaveType { get; set; }
            /// <summary>
            /// 请假开始时间
            /// </summary>
            public DateTime StartDate { get; set; }
            /// <summary>
            /// 请假结束时间
            /// </summary>
            public DateTime EndDate { get; set; }
            /// <summary>
            /// 请假天数
            /// </summary>
            public int Day { get; set; }
            /// <summary>
            /// 请假原因
            /// </summary>
            public string LeaveCause { get; set; }
            /// <summary>
            /// 附件上传
            /// </summary>
            public string LeaveImg { get; set; }
            /// <summary>
            /// 请假备注
            /// </summary>
            public string LeaveRemark { get; set; }
        }
}
