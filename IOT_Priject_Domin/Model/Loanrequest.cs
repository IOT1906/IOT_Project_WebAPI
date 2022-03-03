using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model 
{
    /// <summary>
    /// 固定资产资料借用表
    /// </summary>
    public class Loanrequest : BaseModels
    {

        public int Id { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public int Applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Applicationdepartment { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Dateofapplication { get; set; }
        /// <summary>
        /// 归还日期
        /// </summary>
        public string Returndate { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Assetname { get; set; }
        /// <summary>
        /// 资产型号
        /// </summary>
        public string Assetmodel { get; set; }
        /// <summary>
        /// 资料名称
        /// </summary>
        public string Profilename { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
    }
}
