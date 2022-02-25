using IOT_Project_IRepository;
using IOT_Project_MyDB;
using IOT_Project_Repository;
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
            //EFǨ�����ݿ⡪������ע��BPMMyUsers�Ĳ�ӳ��
            var con = Configuration.GetConnectionString("con");
            services.AddDbContext<MyDbContext>(option => option.UseSqlServer(con));
            //ע��ִ���
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            //����
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
            ///��֤�������
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                //��һ����Ǿ���payload
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    // �Ƿ���ǩ����֤
                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("secretKey").Value)),
                    // ��������֤������Ҫ��token����Claim���͵ķ����˱���һ��
                    ValidateIssuer = true,
                    ValidIssuer = "API",//������
                    // ��������֤
                    ValidateAudience = true,
                    ValidAudience = "User",//������
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
            //��������
            app.UseCors("ljq");

            app.UseRouting();

            //��֤
            app.UseAuthentication();
            //��Ȩ
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
