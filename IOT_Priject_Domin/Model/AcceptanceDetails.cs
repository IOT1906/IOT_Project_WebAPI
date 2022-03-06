using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 详细信息
    /// </summary>
    public class AcceptanceDetails
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Asset_name { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Accessorymodel { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string Quantity { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string Unit_price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string Amount { get; set; }
        /// <summary>
        /// 供货单位
        /// </summary>
        public string Suppliers { get; set; }
        /// <summary>
        /// 采购人
        /// </summary>
        public string Purchaser { get; set; }
    }
}
