using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 公告基本信息
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// 公告基本主键Id
        /// </summary>
        [Key]
        public int AnnounId { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 类型---手动输入
        /// </summary>
        public string Typing { get; set; }
        /// <summary>
        /// 发布时间---当前时间
        /// </summary>
        public string Release_time { get; set; }
        /// <summary>
        /// 标题---手动输入
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容---手动输入
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 附件---手动添加
        /// </summary>
        public string Attachment { get; set; }
      
    }
}
