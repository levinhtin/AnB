using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using AnB.Data.Articles.Context;
using AnB.Data.Ecommerce.Context;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Data.Entity;
using AnB.Site.Models;

namespace AnB.Site
{
    public class Startup
    {
        public Startup()
        {
            Configuration = new Configuration()
            .AddJsonFile("config.json")
            .AddEnvironmentVariables();
            
        }
        public IConfiguration Configuration { get; private set; }
        public Startup(IHostingEnvironment env)
        {
        }
        // This method gets called by a runtime.
        // Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFramework(Configuration)
                .AddSqlServer()
                .AddDbContext<EcommerceContext>();
            // Add Identity services to the services container.
            //services.AddDefaultIdentity<ApplicationDbContext, ApplicationUser, IdentityRole>(Configuration);

        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseWelcomePage();
            app.UseStaticFiles();
            // Add MVC to the request pipeline.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
