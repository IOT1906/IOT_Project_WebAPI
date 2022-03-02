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
        /// 会议室新增
        /// </summary>
        public DbSet<Meeting> Meeting { get; set; }

        /// <summary>
        /// 日常用品采购申请单——详细信息
        /// </summary>
        public DbSet<Dailydetailed> Dailydetailed { get; set; }


        /// <summary>
        /// 日常用品采购申请单
        /// </summary>
        public DbSet<Daily> Daily { get; set; }


        /// <summary>
        /// 接待申请表——物品详细信息
        /// </summary>
        public DbSet<ReceItemDetails> ReceItemDetails { get; set; }


        /// <summary>
        /// 接待申请表——行程信息
        /// </summary>

        public DbSet<ReceItineraryDetails> ReceItineraryDetails { get; set; }


        /// <summary>
        /// 接待申请表
        /// </summary>
        public DbSet<Receptionbase> Receptionbase { get; set; }



        /// <summary>
        /// 离职表
        /// </summary>
        public DbSet<Departure> Departure { get; set; }
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<BPMSysUsers> BPMSysUsers { get; set; }
        /// <summary>
        /// 角色表
        /// 年度计划表
        /// </summary>
        public DbSet<BPMSysOURoles> BPMSysOURoles { get; set; }
        public DbSet<Annual_plan> Annual_plan { get; set; }
        /// <summary>
        /// 部门表
        /// 本年预计增加
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
        ///</summary>
        public DbSet<ResourcesRequirements> ResourcesRequirements { get; set; }
        public DbSet<Expected_increase_this_year> Expected_increase_this_year { get; set; }
        /// <summary>
        /// 请假表迁移
        /// </summary>
        public DbSet<Leave> Leave { get; set; }
        /// <summary>
        /// 固定资产购置申请表
        /// </summary>
        public DbSet<Acquisitionassets> Acquisitionassets { get; set; }
        /// <summary>
        /// 固定资产交接表
        /// </summary>
        public DbSet<Connect> Connect { get; set; }
        /// <summary>
        /// 固定资产资料借用表
        /// </summary>
        public DbSet<Loanrequest> Loanrequest { get; set; }
        /// <summary>
        /// 离职交接表迁移
        /// </summary>
        public DbSet<HandOver> HandOver { get; set; }
        /// <summary>
        /// 用车申请表迁移
        /// </summary>
        public DbSet<Carapply> Carapply { get; set; }
        /// <summary>
        /// 员工离职面谈表迁移
        /// </summary>
        public DbSet<Interview> Interview { get; set; }
    }
}
