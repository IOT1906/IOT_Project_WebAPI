using IOT_Priject_Domin.InputModel;
using IOT_Priject_Domin.Model;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_MyDB
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        { 
        }
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<BPMSysUsers> BPMSysUsers { get; set; }
        /// <summary>
        /// 角色表
        /// </summary>
        public DbSet<BPMSysOURoles> BPMSysOURoles { get; set; }
        /// <summary>
        /// 部门表
        /// </summary>
        public DbSet<BPMSysOUs> BPMSysOUs { get; set; }
        /// <summary>
        /// 用户录入表
        /// </summary>
        public DbSet<staff_entering> taff_entering { get; set; }
        /// <summary>
        /// 用户亲属表
        /// </summary>
        public DbSet<userkinsfolk> userkinsfolk { get; set; }
        /// <summary>
        /// 人力资源申请表
        /// </summary>
        public DbSet<ResourcesRequirements> ResourcesRequirements { get; set; }

    }
}
