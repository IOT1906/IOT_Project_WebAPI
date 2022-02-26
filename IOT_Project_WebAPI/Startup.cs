using IOT_Project_IRepository;
using IOT_Project_IServices;
using IOT_Project_MyDB;
using IOT_Project_Repository;
using IOT_Project_Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //EF迁移数据库————注意BPMMyUsers的不映射
            var con = Configuration.GetConnectionString("con");
            services.AddDbContext<MyDbContext>(option => option.UseSqlServer(con));
            //注入仓储层
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //注入请假服务层
            services.AddScoped<LeaveIservices, LeaveServices>();
            //注入人力资源申请层
            services.AddScoped<ResourcesRequirementsIServices, ResourcesRequirementsServices>();
            //注入年度计划服务层
            services.AddScoped<Annual_PlanIServices, Annual_PlanServices>();
            //跨域
            services.AddCors(s =>
            {
                s.AddPolicy("ljq", s =>
                {
                    s.AllowAnyMethod().AllowAnyHeader()
                     .SetIsOriginAllowed(_ => true).AllowCredentials();
                });
            });



            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Permission_API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement { {
                    new OpenApiSecurityScheme{
                     Reference=new OpenApiReference{
                      Id="Bearer", Type= ReferenceType.SecurityScheme
                     }
                    },
                    new string[]{ }
                    }
                });

            });
            ///认证服务代码
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                //这一坨就是就是payload
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    // 是否开启签名认证
                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("secretKey").Value)),
                    // 发行人验证，这里要和token类中Claim类型的发行人保持一致
                    ValidateIssuer = true,
                    ValidIssuer = "API",//发行人
                    // 接收人验证
                    ValidateAudience = true,
                    ValidAudience = "User",//订阅人
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IOT_Project_WebAPI v1"));
            }
            //跨域设置
            app.UseCors("ljq");

            app.UseRouting();


            //认证
            app.UseAuthentication();
            //授权

            //锟斤拷证
            app.UseAuthentication();
            //锟斤拷权

            //锟斤拷证
            app.UseAuthentication();
            //锟斤拷权

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
