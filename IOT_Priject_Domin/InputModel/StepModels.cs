using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
    public class StepModels:BaseModels
    {
        public int StepId { get; set; }
        public string Comments { get; set; }
    }
}
