using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VogCodeChallenge.API.DataAccess;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API
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
            AddUnitOfWork(services, this.Configuration);
            AddDataAccess(services);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void AddUnitOfWork(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext>(ctx => new DbContext());

            services.AddScoped<IUnitOfWork>(ctx => new TestUnitOfWork(ctx.GetRequiredService<DbContext>()));
        }

        private static void AddDataAccess(IServiceCollection services)
        {
            // Employee Service
            var empServiceType = typeof(EmployeeService);
            var types = (from t in empServiceType.GetTypeInfo().Assembly.GetTypes()
                         where t.Namespace == empServiceType.Namespace
                               && t.GetTypeInfo().IsClass
                               && t.GetTypeInfo().GetCustomAttribute<CompilerGeneratedAttribute>() == null
                         select t).ToArray();

            foreach (var type in types)
            {
                services.AddScoped(type, type);
            }

            // Department Service
            var depServiceType = typeof(DepartmentService);
            var depTypes = (from t in depServiceType.GetTypeInfo().Assembly.GetTypes()
                            where t.Namespace == depServiceType.Namespace
                                  && t.GetTypeInfo().IsClass
                                  && t.GetTypeInfo().GetCustomAttribute<CompilerGeneratedAttribute>() == null
                            select t).ToArray();

            foreach (var type in depTypes)
            {
                var interfaceQ = type.GetTypeInfo().DeclaringType;
                services.AddScoped(type, type);
            }
        }
    }
}
