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

            services.AddAntiforgery(options =>
            {
                options.HeaderName = "X-CSRF-TOKEN";
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
            services.AddTransient<IAccountsService, AccountsService>();
            services.AddTransient<IAchievementsService, AchievementsService>();
            services.AddTransient<IBaseThreadsService, BaseThreadsService>();
            services.AddTransient<IBugReportsService, BugReportsService>();
            services.AddTransient<ICharactersService, CharactersService>();
            services.AddTransient<IClassesService, ClassesService>();
            services.AddTransient<ICompetitionsService, CompetitionsService>();
            services.AddTransient<IPostsService, PostsService>();
            services.AddTransient<IPostReportsService, PostReportsService>();
            services.AddTransient<IRacesService, RacesService>();
            services.AddTransient<IServersService, ServersService>();
            services.AddTransient<IThreadsService, ThreadsService>();
            services.AddTransient<IVotesService, VotesService>();
            services.AddTransient<ICompetitionCharactersService, CompetitionCharactersService>();
            services.AddTransient<ICompetitionVotesService, CompetitionVotesService>();
            services.AddTransient<IHtmlSizeParser, HtmlSizeParser>();
            services.AddTransient(typeof(AccountsService));
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
                      name: "areas",
                      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
