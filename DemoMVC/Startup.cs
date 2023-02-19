using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DemoMVC
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute(
                    name: "home",
                    defaults: new
                    {
                        controller = "Home",
                        action = "Index"
                    },
                    pattern: "/"
                );
                endpoint.MapControllerRoute("test", defaults: new
                {
                    controller = "Demo",
                    action = "Render"
                }, pattern: "/demo"

                
                );
                
               
            });





                // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.Configure<RouteOptions>(option =>
            {
                option.LowercaseUrls = true;
                option.AppendTrailingSlash = false;
                option.LowercaseQueryStrings = true;
            });
        }
        

       
    }
}

