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
        /// 请假表迁移
        /// </summary>
        public DbSet<Leave> Leave { get; set; }

    }
}
