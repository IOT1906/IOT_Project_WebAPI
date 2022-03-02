using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
   [NotMapped]
    public class inputDeparture : BaseModels
    {
        [Key]
        /// <summary>
        /// 离职表Id
        /// </summary>
        public int DepId { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人-带出当前登录人员账号不可填写
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 申请部门-带出当前登录人员账号不可填写
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 申请日期-自动填写
        /// </summary>
        public DateTime DepTime { get; set; }
        /// <summary>
        ///职位-带出当前登录人员账号不可填写
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        ///入职日期-带出当前登录人员账号不可填写
        /// </summary>
        public DateTime StakeTime { get; set; }
        /// <summary>
        /// 离职日期-手动填写
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 离职类型-手动填写
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 离职原因-手动填写
        /// </summary>
        public string Depwhy { get; set; }
        /// <summary>
        /// 备注-手动填写
        /// </summary>
        public string Depnote { get; set; }
    }
}
