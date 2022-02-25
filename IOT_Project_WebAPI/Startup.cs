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

            //EFÇ¨ÒÆÊý¾Ý¿â¡ª¡ª¡ª¡ª×¢ÒâBPMMyUsersµÄ²»Ó³Éä
            var con = Configuration.GetConnectionString("con");
            services.AddDbContext<MyDbContext>(option => option.UseSqlServer(con));
            //×¢Èë²Ö´¢²ã
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            //¿çÓò
            //EFÇ¨ï¿½ï¿½ï¿½ï¿½ï¿½Ý¿â¡ªï¿½ï¿½ï¿½ï¿½ï¿½ï¿½×¢ï¿½ï¿½BPMMyUsersï¿½Ä²ï¿½Ó³ï¿½ï¿½
      
            services.AddDbContext<MyDbContext>(option => option.UseSqlServer(con));
            //×¢ï¿½ï¿½Ö´ï¿½ï¿½ï¿?

            //EFÇ¨ï¿½ï¿½ï¿½ï¿½ï¿½Ý¿â¡ªï¿½ï¿½ï¿½ï¿½ï¿½ï¿½×¢ï¿½ï¿½BPMMyUsersï¿½Ä²ï¿½Ó³ï¿½ï¿½
        
            services.AddDbContext<MyDbContext>(option => option.UseSqlServer(con));
            //×¢ï¿½ï¿½Ö´ï¿½ï¿½ï¿?

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            //ï¿½ï¿½ï¿½ï¿½

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

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                //ÕâÒ»Ûç¾ÍÊÇ¾ÍÊÇpayload
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    // ÊÇ·ñ¿ªÆôÇ©ÃûÈÏÖ¤
                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("secretKey").Value)),
                    // ·¢ÐÐÈËÑéÖ¤£¬ÕâÀïÒªºÍtokenÀàÖÐClaimÀàÐÍµÄ·¢ÐÐÈË±£³ÖÒ»ÖÂ
                    ValidateIssuer = true,
                    ValidIssuer = "API",//·¢ÐÐÈË
                    // ½ÓÊÕÈËÑéÖ¤
                    ValidateAudience = true,
                    ValidAudience = "User",//¶©ÔÄÈË
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

            app.UseCors("ljq");

            app.UseRouting();


            //ÈÏÖ¤
            app.UseAuthentication();
            //ÊÚÈ¨

            //ï¿½ï¿½Ö¤
            app.UseAuthentication();
            //ï¿½ï¿½È¨

            //ï¿½ï¿½Ö¤
            app.UseAuthentication();
            //ï¿½ï¿½È¨

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
