using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
    /// <summary>
    /// 年度计划表
    /// </summary>
    public class Annual_plans : BaseModels
    {
        [Key]
        /// <summary>
        /// 年度Id
        /// </summary>
        public int Annualid { get; set; }
        /// <summary>
        /// 制表人---手动输入
        /// </summary>
        public string Tabulator { get; set; }
        /// <summary>
        /// 制表部门---手动输入
        /// </summary>
        public string Tabulation_Department { get; set; }
        /// <summary>
        /// 制表时间---自动生成
        /// </summary>
        public string Tabulation_time { get; set; } = @DateTime.Now.ToString("yyyy年mm月dd H:mm:ss");
        /// <summary>
        /// 年份---自动输入
        /// </summary>
        public string Particular_year { get; set; } = @DateTime.Now.ToString("yyyy");














    }
}
