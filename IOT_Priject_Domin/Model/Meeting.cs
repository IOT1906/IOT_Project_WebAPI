using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 会议室新增
    /// </summary>
    public class Meeting
    {
        [Key]
        public int MyPId { get; set; }
        /// <summary>
        ///  TaskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 会议室新增——会议室名称
        /// </summary>
        public string MyPName { get; set; }
        /// <summary>
        /// 会议室新增——座位
        /// </summary>
        public string MyPseat { get; set; }
        /// <summary>
        /// 会议室新增——楼层
        /// </summary>
        public string MyPfloor { get; set; }
        /// <summary>
        /// 会议室新增——容纳人数
        /// </summary>
        public string MyPaccommodate { get; set; }
        /// <summary>
        /// 会议室新增——空调
        /// </summary>
        public string MyPconditioner { get; set; }
        /// <summary>
        /// 会议室新增——投影仪
        /// </summary>
        public string MyPprojector { get; set; }
        /// <summary>
        /// 会议室新增——白板
        /// </summary>
        public string MyPwhiteboard { get; set; }
        /// <summary>
        /// 会议室新增——网络
        /// </summary>
        public string MyPnetwork { get; set; }
        /// <summary>
        /// 会议室新增——网络范围
        /// </summary>
        public string MyPrange { get; set; }
        /// <summary>
        /// 会议室新增——饮水机
        /// </summary>
        public string MyPdispenser { get; set; }
        /// <summary>
        /// 会议室新增——管理员
        /// </summary>
        public string MyPadministrator { get; set; }
        /// <summary>
        /// 会议室新增——照片
        /// </summary>
        public string MyPphotograph { get; set; }
        /// <summary>
        /// 会议室新增——备注
        /// </summary>
        public string MyPnote { get; set; }

    }
}
