using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 固定资产验收单
    /// </summary>
    public class Assetacceptance
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Applicationdepartment { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Dateofapplication { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string Assetnumber { get; set; }
        /// <summary>
        /// 资产类别
        /// </summary>
        public string Assetclass { get; set; }
        /// <summary>
        /// 存放地点
        /// </summary>
        public string Storagelocation { get; set; }
        /// <summary>
        /// 申购单号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 所属项目
        /// </summary>
        public string Project { get; set; }
        /// <summary>
        /// 使用人
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string Department { get; set; }

    }
}
