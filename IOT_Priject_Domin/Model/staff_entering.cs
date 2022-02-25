using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 录入员工表
    /// </summary>
    public class staff_entering
    {
        [Key]
        /// <summary>
        /// 录入员工表id
        /// </summary>
        public int sid { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 员工录入选择部门的id--拉取获取
        /// </summary>
        public int departmentid { get; set; }
        /// <summary>
        /// 员工录入选择岗位--拉去获取
        /// </summary>
        public int roleid { get; set; }
        /// <summary>
        /// 员工录入的核定日期--选择日期
        /// </summary>
        public DateTime vouchtime { get; set; }
        /// <summary>
        /// 员工录入的岗位说明--已设/新增/临时
        /// </summary>
        public int explain { get; set; }
        /// <summary>
        /// 员工录入的角色类别--员工/主管级/经理级/其他
        /// </summary>
        public int roletype { get; set; }
        /// <summary>
        /// 录入员工的姓名
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 录入员工的性别
        /// </summary>
        public int sex { get; set; }
        /// <summary>
        /// 员工录入的出生年月
        /// </summary>
        public DateTime birthday { get; set; }
        /// <summary>
        /// 录入员工的文化程度
        /// </summary>
        public string culturedegree { get; set; }
        /// <summary>
        /// 录入员工的健康状况
        /// </summary>
        public string health { get; set; }
        /// <summary>
        /// 录入员工的电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 录入员工的住址
        /// </summary>
        public string site { get; set; }
        /// <summary>
        /// 录入员工的特长
        /// </summary>
        public string speciality { get; set; }
        /// <summary>
        /// 录入员工是否有亲属在本公司工作
        /// </summary>
        public int whether { get; set; }
        /// <summary>
        /// 录入员工的拟核工资及待遇
        /// </summary>
        public string treatment { get; set; }
        /// <summary>
        /// 录入员工的合同期限
        /// </summary>
        public int contract_deadline { get; set; }
        /// <summary>
        ///录入员工管的试用期
        /// </summary>
        public string qualifying_period { get; set; }


    }
}
