using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 固定资产交接表
    /// </summary>
    public class Connect : BaseModels
    {
        /// <summary>
        /// 申请人
        /// </summary>
        public int Id { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Applicationdepartment { get; set; }
        /// <summary>
        /// 交接表单
        /// </summary>
        public string Handoverform { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string Assetnumber { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Assetname { get; set; }
        public string Handover { get; set; }
        /// <summary>
        /// 交接人部门
        /// </summary>
        public string Handoverdepartment { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
