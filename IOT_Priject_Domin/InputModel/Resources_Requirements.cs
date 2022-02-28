using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.InputModel
{
    
    public class Resources_Requirements :BaseModels
    {
        [Key]
        public int Id { get; set; }

        public int TaskId { get; set; }
        /// <summary>
        /// 申请部门  自动生成申请部门不可填写
        /// </summary>
        public string Applicationdepartment { get; set; }
        /// <summary>
        /// 申请时间 自动生成当前时间不可填写
        /// </summary>
        public string Applicationtime { get; set; }
        /// <summary>
        /// 岗位名称 手动填写
        /// </summary>
        public string Jobtitle { get; set; }
        /// <summary>
        /// 岗位说明 单选
        /// </summary>
        public string Jobdescription { get; set; }
        /// <summary>
        /// 现有人数 自动生成现有人数
        /// </summary>
        public string Numberofpeopleonhand { get; set; }
        /// <summary>
        /// 招募人数 手动填写
        /// </summary>
        public string Numberofrecruits { get; set; }
        /// <summary>
        /// 性别 手动填写
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄 手动填写
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 文化程度 手动填写
        /// </summary>  
        public string Education { get; set; }
        /// <summary>
        /// 专业要求 手动填写
        /// </summary>        
        public string Professionalrequirements { get; set; }
        /// <summary>
        /// 岗位要求 手动填写
        /// </summary>        
        public string Jobrequirements { get; set; }
        /// <summary>
        /// 其他 手动填写
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        /// 薪资待遇 手动填写
        /// </summary>
        public string Salarypackage { get; set; }
        /// <summary>
        /// 拟聘合同 手动填写
        /// </summary>
        public string Contract { get; set; }
        /// <summary>
        /// 试用期 手动填写
        /// </summary>
        public string Probationperiod { get; set; }
        /// <summary>
        /// 申请原因 多行文本填入
        /// </summary>
        public string Reasonforapplication { get; set; }
        /// <summary>
        /// 附件 手动上传文件
        /// </summary>
        public string Annex { get; set; }
        /// <summary>
        /// 备注 多行文本填入 
        /// </summary>
        public string Remark { get; set; }
    }
}
