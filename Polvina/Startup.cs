using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonBaseType.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Polvina
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
            services.AddControllers();
  #region Db Context

            services.AddDbContext<BaseType_Context>(Option =>
            {
                Option.UseSqlServer("Server=(local);Database=Charity_DB;Trusted_Connection=True;");

            });


            #endregion
            #region InterFace

            services.AddScoped<IBaseTypeRepository, BaseTypeRepository>();
            #endregion
=======
            services.AddSwaggerGen();

            services.AddDbContext<Contexts>(Option => Option.UseSqlServer(Configuration.GetConnectionString("MycontectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            app.UseSwagger();
            app.UseSwaggerUI(c =>{
                c.SwaggerEndpoint("/swagger/v1/swagger.json","my api v1");
                });

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
    }
}
