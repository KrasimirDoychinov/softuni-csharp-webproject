using System;
using System.Reflection;

using Hangfire;
using Hangfire.SqlServer;
using SixLabors.ImageSharp.Web.DependencyInjection;

using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Web.Hubs;
using HolocronProject.Web.Seeder;
using HolocronProject.Web.Models;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Services.EmailSender;
using HolocronProject.Services.Implementations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential 
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                // requires using Microsoft.AspNetCore.Http;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddControllersWithViews(cfg =>
            {
                cfg.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            services.AddAntiforgery(options =>
            {
                options.HeaderName = "X-CSRF-TOKEN";
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<Account>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddSignalR(o =>
            {
                o.EnableDetailedErrors = true;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                }));

            // Add the processing server as IHostedService
            services.AddHangfireServer();

            // Add framework services.
            services.AddMvc();

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
            services.AddTransient<ICompetitionAccountsService, CompetitionAccountsService>();
            services.AddTransient<IHtmlSizeParser, HtmlSizeParser>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient(typeof(AccountsService));
            services.AddTransient(typeof(Random));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IBackgroundJobClient backgroundJobs, IWebHostEnvironment env,
            UserManager<Account> userManager,
            RoleManager<IdentityRole> roleManager,
            IAccountsService accountsService)
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
            app.UseCookiePolicy();

            app.UseHangfireServer();
            app.UseHangfireDashboard();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            DataSeeder.SeedData(userManager, roleManager, accountsService);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<VoteHub>("/vote");
                endpoints.MapHangfireDashboard();

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
