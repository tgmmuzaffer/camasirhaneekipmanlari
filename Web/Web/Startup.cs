using AspNetCore.SEOHelper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Recaptcha.Web.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Extensions;

namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            RecaptchaConfigurationManager.SetConfiguration(Configuration);
            services.ConfigureServices();
            services.AddResponseCaching();
            services.AddMemoryCache(); 
            services.AddHttpClient();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseExceptionHandler("/notfound");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Xss-Protection", "1; mode=block");
                context.Response.Headers.Remove("Server");
                string path = context.Request.Path;

                if (path.EndsWith(".css") || path.EndsWith(".js") || path.EndsWith(".webp") || path.EndsWith(".png"))
                {
                    TimeSpan maxAge = new TimeSpan(7, 0, 0, 0);
                    context.Response.Headers.Append("Cache-Control", "max-age=" + maxAge.TotalSeconds.ToString("0"));
                }
                else
                {
                    context.Response.Headers.Append("Cache-Control", "no-cache");
                    context.Response.Headers.Append("Cache-Control", "private, no-store");
                }

                await next();
                if (context.Response.StatusCode == 404 || context.Response.StatusCode == 500)
                {
                    var routeNF = "/notfound";
                    context.Request.Path = routeNF;
                    await next();
                }
            });
            app.UseResponseCaching();
            app.UseStaticFiles();
            app.UseXMLSitemap(env.ContentRootPath);
            app.UseRouting();

            app.UseAuthorization();
            app.UseXMLSitemap(env.ContentRootPath);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
