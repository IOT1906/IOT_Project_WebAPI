using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 文件管理
    /// </summary>
    public class Management
    {
        [Key]
        public int ManId { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 文件管理
        /// </summary>
        public string ManType { get; set; }
        /// <summary>
        /// 文件所属部门
        /// </summary>
        public string Mandocuments { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string ManName { get; set; }
        /// <summary>
        /// 归档日期
        /// </summary>
        public string ManDate { get; set; }
        /// <summary>
        /// 文件编号
        /// </summary>
        public string Mannumber { get; set; }
        /// <summary>
        /// 归档人
        /// </summary>
        public string Manarchiver { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Mancontent { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Manattachment { get; set; }



    }
}
