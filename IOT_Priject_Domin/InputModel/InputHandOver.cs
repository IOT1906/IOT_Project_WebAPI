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
    /// 离职交接表
    /// </summary>
    public class InputHandOver: BaseModels
    {

        [Key]
        /// <summary>
        /// 离职交接表——Id
        /// </summary>
        public int HId { get; set; }
        /// <summary>
        /// 离职交接表——TaskId
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// 离职交接表——申请人
        /// </summary>
        public string HandName { get; set; }
        /// <summary>
        /// 离职交接表——申请部门
        /// </summary>
        public string HandDemp { get; set; }
        /// <summary>
        /// 离职交接表——申请日期
        /// </summary>
        public string Handdate { get; set; }
        /// <summary>
        /// 离职交接表——职位
        /// </summary>
        public string Handpostion { get; set; }
        /// <summary>
        /// 离职交接表——是否要离职证明
        /// </summary>
        public string HandProve { get; set; }
        /// <summary>
        /// 离职交接表——附件
        /// </summary>
        public string HandImgurl { get; set; }
        /// <summary>
        /// 离职交接表——选择交接人
        /// </summary>
        public string HandHeir { get; set; }
        /// <summary>
        /// 离职交接表——部门交接内容
        /// </summary>
        public string HandDempContent { get; set; }
        /// <summary>
        /// 离职交接表——部门交接情况
        /// </summary>
        public string HandDempCondition { get; set; }
        /// <summary>
        /// 离职交接表——财务部交接内容
        /// </summary>
        public string HandFinceContent { get; set; }
        /// <summary>
        /// 离职交接表——财务部交接情况
        /// </summary>
        public string HandFinceCondition { get; set; }
        /// <summary>
        /// 离职交接表——行政部交接内容
        /// </summary>
        public string HandStativeContent { get; set; }
        /// <summary>
        /// 离职交接表——行政部交接情况
        /// </summary>
        public string HandStativeCondition { get; set; }
        /// <summary>
        /// 离职交接表——备注
        /// </summary>
        public string HandRemark { get; set; }
    }
}
