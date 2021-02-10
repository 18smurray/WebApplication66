using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication66
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Want developers to see detailed error page, but not the user
            app.UseDeveloperExceptionPage();
            //Use environment type to determine whether or not to show dev error page
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //Add error page
            }
            

            app.UseNodeModules();
            app.UseStaticFiles();

            //Use views/controllers to dynamically determine route
            app.UseRouting();

            //Create default endpoint
            app.UseEndpoints(cfg =>
            {
                //Find pattern: Home controller with Index() action and look for id
                cfg.MapControllerRoute("Default", "{controller}/{action}/{id?}",
                    //If default doesn't work/can't find pattern then use the Home controller with Index as the action
                    new { controller = "Home", action = "Index" });
            });
        }
    }
}
