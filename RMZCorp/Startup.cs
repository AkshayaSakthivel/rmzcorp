using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RMZCorp.DataAccess.SQL;
using RMZCorp.DataAccess.SQL.Contracts;
using RMZCorp.DataAccess.SQL.Repository;
using RMZCorp.Domain.Contracts;
using RMZCorp.Domain.Entities;
using RMZCorps.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp
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
            services.AddRazorPages();
            services.AddControllers();
            services.AddDbContextPool<Context>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly("RMZCorp.DataAccess.SQL")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RMZCorp", Version = "v1" });
            });

            services.AddScoped<IElectricityMeterRepo, ElectricityMeterRepo>();
            services.AddScoped<IWaterMeterRepo, WaterMeterRepo>();
            services.AddScoped<IMeterRepo, MeterRepo>();
            services.AddScoped<IElectricityMeterEntity, ElectricityMeterEntity>();
            services.AddScoped<IWaterMeterEntity, WaterMeterEntity>();
            services.AddScoped<IMeterEntity, MeterEntity>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "RMZCorp v1");
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
