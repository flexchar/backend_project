using MandotaryAssignment01.Models.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MandotaryAssignment01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();
            services.AddSession();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseSession();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: null,
                    template: "catalogue/{category}/page/{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index"
                    }
                );

                routes.MapRoute(
                    name: null,
                    template: "page/{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    }
                );

                routes.MapRoute(
                    name: null,
                    template: "catalogue/{category}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    }
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Catalogue}/{action=Index}/{id?}"
                );
            });

        }
    }
}
