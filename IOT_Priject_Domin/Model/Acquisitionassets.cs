using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    
    /// <summary>
    /// 固定资产购置申请表
    /// </summary>
    public class Acquisitionassets : BaseModels
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 申请人 当前申请人反填不可手填
        /// </summary>
        public string Applicant { get; set; }
        /// <summary>
        /// 申请部门  当前申请部门反填不可手填
        /// </summary>
        public string Applicationdepartment { get; set; }
        /// <summary>
        /// 申请日期  当前申请时间
        /// </summary>
        public string Dateapplication { get; set; }
        /// <summary>
        /// 表单单号  自动生成表单单号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 固定资产名称  手动输入
        /// </summary>
        public string Assetname { get; set; }
        /// <summary>
        /// 型号  手动输入
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// 配置  手动输入
        /// </summary>
        public string Disposition { get; set; }
        /// <summary>
        /// 是否产生资产  单选
        /// </summary>
        public string Whether { get; set; }
        /// <summary>
        /// 申请理由  手动输入
        /// </summary>
        public string Reasonsapplication { get; set; }
        /// <summary>
        /// 备注  手动输入
        /// </summary>
        public string Remark { get; set; }

    }
}
