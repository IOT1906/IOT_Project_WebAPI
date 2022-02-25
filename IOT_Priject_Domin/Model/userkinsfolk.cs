using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Priject_Domin.Model
{
    /// <summary>
    /// 员工亲属
    /// </summary>
    public class userkinsfolk
    {
        /// <summary>
        /// 员工亲属表id
        /// </summary>
        [Key]
        public int uid { get; set; }
        public int Taskid { get; set; }
        /// <summary>
        /// 员工亲属姓名--可填写
        /// </summary>
        public string kinsfolkname { get; set; }
        /// <summary>   
        /// 亲属与员工之间的关系  --可填写
        /// </summary>
        public string relation { get; set; }
        /// <summary>
        /// 亲属在本公司的岗位--可填写
        /// </summary>
        public string kinsfolk_post { get; set; }
    }
}
