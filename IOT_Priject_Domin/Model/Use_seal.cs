using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 用章申请表
    /// </summary>
    public class Use_seal
    {
        /// <summary>
        /// 用章主键Id
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
        /// 印章名称---手动输入
        /// </summary>
        public string Seal_name { get; set; }
        /// <summary>
        /// 是否外借---手动选择
        /// </summary>
        public int Lend_out { get; set; }
        /// <summary>
        /// 陪同人员---手动输入
        /// </summary>
        public string Entourage { get; set; }
        /// <summary>
        /// 归还日期---自己选择
        /// </summary>
        public string Return_date { get; set; }
        /// <summary>
        /// 外出地址---手动输入
        /// </summary>
        public string Out_of_office_address { get; set; }
        /// <summary>
        /// 用印事项或主要内容---手动输入
        /// </summary>
        public string Printing_matters { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

    }
}
