using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.Models;
using System.Reflection;
using SixLabors.ImageSharp.Web.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Identity;

namespace HolocronProject.Web
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
            services.AddControllersWithViews(cfg =>
            {
                cfg.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            services.AddDbContext<HolocronDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<Account>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<HolocronDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();


            services.AddImageSharp();
            services.AddTransient<IAccountService, AccountServices>();
            services.AddTransient<IAchievementService, AchievementServices>();
            services.AddTransient<IBaseThreadService, BaseThreadServices>();
            services.AddTransient<IBugReportService, BugReportServices>();
            services.AddTransient<ICharacterService, CharacterServices>();
            services.AddTransient<IClassService, ClassServices>();
            services.AddTransient<ICompetitionService, CompetitionServices>();
            services.AddTransient<IPostService, PostServices>();
            services.AddTransient<IRaceService, RaceServices>();
            services.AddTransient<IServerService, ServerServices>();
            services.AddTransient<ITagService, TagServices>();
            services.AddTransient<IThreadService, ThreadServices>();
            services.AddTransient(typeof(AccountServices));
            services.AddTransient(typeof(Random));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            UserManager<Account> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);
            app.UseImageSharp();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            MyIdentityDataInitializer.SeedData(userManager, roleManager);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
