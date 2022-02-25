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
        public DbSet<BPMSysUsers> BPMSysUsers { get; set; }
        /// <summary>
        /// 年度计划表
        /// </summary>
        public DbSet<Annual_plan> Annual_plan { get; set; }
        /// <summary>
        /// 本年预计增加
        /// </summary>
        public DbSet<Expected_increase_this_year> Expected_increase_this_year { get; set; }

    }
}
