    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DAL.EF;
using Ninject;
using Ninject.Modules;
using BLL.Infrastructure;
using BLL.Services;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace WEB
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IFacultyService, FacultyService>();
            services.AddTransient<IKnowledgeAreaService, KnowledgeAreaService>();
            services.AddTransient<ISpecialityService, SpecialityService>();
            services.AddTransient<ICathedraService, CathedraService>();
            services.AddTransient<ISpecializationService, SpecializationService>();
            services.AddTransient<ICycleService, CycleService>();
            services.AddTransient<IUnderCycleService, UnderCycleService>();
            services.AddTransient<IFormDeliveryService, FormDeliveryService>();
            services.AddTransient<IFormEducationService, FormEducationService>();
            services.AddTransient<IEducationalDegreeService, EducationalDegreeService>();
            services.AddTransient<ICurriculumService, CurriculumService>();
            services.AddTransient<IPlanEducationalProcessService, PlanEducationalProcessService>();
            services.AddTransient<IGruppaService, GruppaService>();
            services.AddTransient<IStudentInfoService, StudentInfoService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ITeacherInfoService, TeacherInfoService>();
            services.AddTransient<ITeacherService, TeacherService>();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => //CookieAuthenticationOptions
            {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Login");
            });

            services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole",
                     policy => policy.RequireRole("Administrator"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "1",
                     pattern: "{controller=Account}/{action=VHome}");

                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "Home",
                   defaults: new { controller = "Account", action = "VHome" });

                endpoints.MapControllerRoute(
                   name: "2",
                   pattern: "{controller=EducationalDepartment}/{action=GetItems}/{id?}",
                   defaults: new { controller = "EducationalDepartment", action = "GetItems" });

                endpoints.MapControllerRoute(
                  name: "3",
                  pattern: "{controller=CurriculumDepartment}/{action=GetItemsFaculty}/{id?}",
                  defaults: new { controller = "CurriculumDepartment", action = "GetItemsFaculty" });
            });

            
        }
    }
}
