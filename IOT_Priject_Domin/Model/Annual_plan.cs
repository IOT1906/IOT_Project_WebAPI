using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 年度计划表
    /// </summary>
    public class Annual_plan 
    {

        [Key]
        /// <summary>
        /// 年度Id
        /// </summary>
        public int Annualid { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 制表人---自动生成
        /// </summary>
        public string Tabulator { get; set; }
        /// <summary>
        /// 制表部门---自动生成
        /// </summary>
        public string Tabulation_Department { get; set; }
        /// <summary>
        /// 制表时间---自动生成
        /// </summary>
        public string Tabulation_time { get; set; }
        /// <summary>
        /// 年份---自动生成
        /// </summary>
        public string Particular_year { get; set; }














    }
}
