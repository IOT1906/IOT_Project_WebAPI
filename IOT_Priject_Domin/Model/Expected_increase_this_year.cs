using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 本年预计增加
    /// </summary>
    public class Expected_increase_this_year
    {
        /// <summary>
        /// 年度id
        /// </summary>
        [Key]
        public int YearId { get; set; }
        public int TackId { get; set; }
        /// <summary>
        /// 岗位---下拉选择
        /// </summary>
        public int Station { get; set; }
        /// <summary>
        /// 上年已有---手动输入
        /// </summary>
        public string Last_year { get; set; }
        /// <summary>
        /// 一月份---手动输入
        /// </summary>
        public int January { get; set; }
        /// <summary>
        /// 二月份---手动输入
        /// </summary>
        public int February { get; set; }
        /// <summary>
        /// 三月份---手动输入
        /// </summary>
        public int March { get; set; }
        /// <summary>
        /// 四月份---手动输入
        /// </summary>
        public int April { get; set; }
        /// <summary>
        /// 五月份---手动输入
        /// </summary>
        public int May { get; set; }
        /// <summary>
        /// 六月份---手动输入
        /// </summary>
        public int June { get; set; }
        /// <summary>
        /// 七月份---手动输入
        /// </summary>
        public int July { get; set; }
        /// <summary>
        /// 八月份---手动输入
        /// </summary>
        public int August { get; set; }
        /// <summary>
        /// 九月份---手动输入
        /// </summary>
        public int September { get; set; }
        /// <summary>
        /// 十月份---手动输入
        /// </summary>
        public int October { get; set; }
        /// <summary>
        /// 十一月份---手动输入
        /// </summary>
        public int November { get; set; }
        /// <summary>
        /// 十二月份---手动输入
        /// </summary>
        public int December { get; set; }
        /// <summary>
        /// 备注---手动输入
        /// </summary>
        public string Remarks { get; set; }
    }
}
