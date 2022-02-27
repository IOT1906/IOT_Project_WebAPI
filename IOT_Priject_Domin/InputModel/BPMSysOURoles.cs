using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
    //[NotMapped]
    /// <summary>
    /// 角色表
    /// </summary>
    public class BPMSysOURoles
    {
        [Key]
        public int OUID { get; set; }
        public string RoleName { get; set; }
    }
}
