using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModels
{
    public class ReceAll: BaseModels
    {
        public string ReceItemDetails { get; set; }
        public string ReceItineraryDetails { get; set; }
        public string Receptionbase { get; set; }
    }
}
