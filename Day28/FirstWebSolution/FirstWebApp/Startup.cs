using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(
                opts=>opts.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           // string envr;
            if (env.IsDevelopment())
            {
                //envr = "Development";
                app.UseDeveloperExceptionPage();
            }
            //else if (env.IsProduction())
            //    //envr = "Production";
            //else
            //    //envr = "Testing";

            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World! ");
            //    });
            //    endpoints.MapGet("/first", async context =>
            //    {
            //        await context.Response.WriteAsync("First response ");
            //    });
            //});
        }
    }
}
