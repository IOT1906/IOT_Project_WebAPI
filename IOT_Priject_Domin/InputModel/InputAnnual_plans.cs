using bpmdemoapi.models;
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
    /// 年度计划表
    /// </summary>
    public class InputAnnual_plans : BaseModels
    
    {
        public string Annual_plans { get; set; }
        public string IOT_Priject_Domininput { get; set; }
    } 
}

