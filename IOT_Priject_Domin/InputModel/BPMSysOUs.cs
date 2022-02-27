using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
     //[NotMapped]
    /// <summary>
    ///部门表
    /// </summary>
    public class BPMSysOUs
    {
        [Key]
        /// <summary>
        ///部门ID
        /// </summary>
        public int OUID { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string OUName { get; set; }
    }
}
