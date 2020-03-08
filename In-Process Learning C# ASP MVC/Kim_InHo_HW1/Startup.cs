using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Kim_InHo_HW1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //These lines allow you to see more detailed error messages
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            //This line allows you to use static pages like style sheets and images
            app.UseStaticFiles();
            //This line configures the routing for MVC
            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
               template: "{controller}/{action}/{id?}",
               defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
