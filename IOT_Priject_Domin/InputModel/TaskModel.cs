using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
   public  class TaskModel:BaseModels
    {
        public int TaskId { get; set; }
        public string Comments { get; set; }
    }
}
