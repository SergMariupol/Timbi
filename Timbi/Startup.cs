using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;
using Timbi.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Timbi.Data;

namespace Timbi
{
    public class Startup
    {
        private IConfigurationRoot confstring;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            confstring = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsetings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(options => options.UseSqlServer(confstring.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllRegistration, RegistrationRepository>();//���������� �����������
            services.AddTransient<IAllPersonalArea, PersonalAreaRepository>();//���������� �����������


            //        services.AddDbContext<ApplicationContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));



            //services.AddDbContext<ApplicationContext>(options =>
            //        options.UseSqlServer(confstring.GetConnectionString("DefaultConnection1")));

            services.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<AppDbContent>();//�����������


            //services.AddIdentity<User, IdentityRole>()
            //  .AddEntityFrameworkStores<AppDbContent>();//�����������

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();           
            services.AddMvc(options => options.EnableEndpointRouting = false);// add mvc
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
            app.UseMvcWithDefaultRoute();

            app.UseRouting();
            app.UseDeveloperExceptionPage();//error list
            app.UseStatusCodePages();//code page
            app.UseStaticFiles();//static files

            app.UseAuthentication();    // ����������� ��������������
            app.UseAuthorization();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});


            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(name: "default", template: "{controller = Home}/{ation=index}/{id?}");
            //    / routes.MapRoute(name: "categoryFilter", template: "{controller = Car}/{ation=index}/{category?}", defaults: new { Controller = "Car", acrion = "List" });
            //});


            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller = Home}/{ation=index}/{id?}");
               // routes.MapRoute(name: "categoryFilter", template: "{controller = Home}/{ation=index}/{category?}", defaults: new { Controller = "Start", action = "StartPage" });
            });

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
            //    DBObjects.Initial(content);
            //}
        }
    }
}
