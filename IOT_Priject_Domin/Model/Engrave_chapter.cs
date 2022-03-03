using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 刻章申请表
    /// </summary>
    public class Engrave_chapter
    {
        /// <summary>
        /// 刻章主键Id
        /// </summary>
        [Key]
        public int AnnounId { get; set; }
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
        /// 申请日期-不可填写
        /// </summary>
        public string DepTime { get; set; }
        /// <summary>
        /// 刻章名称---手动输入
        /// </summary>
        public string Seal_name { get; set; }
        /// <summary>
        /// 用途---手动输入
        /// </summary>
        public string MyProperty { get; set; }
        /// <summary>
        /// 刻章留印标记---手动选择
        /// </summary>
        public string Imprint_mark { get; set; }
        /// <summary>
        /// 备注---手动输入
        /// </summary>
        public string Remarks { get; set; }












    }
}
