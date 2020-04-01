using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TorrServ.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TorrServData.Models;
using TorrServCore;
using TorrServRepositories.UoW;
using Serilog;
using MoviesDownloader;
using CommentService;
using Hangfire;
using AFINNService;
using LemmatizationService;

namespace TorrServ
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("TorrServ")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //add hangfire
           // services.AddHangfire(config =>
                    // config.UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IGenericRepository<TorrentMovie>, TorrentMoveRepository>();
            services.AddTransient<IGenericRepository<SourceOfMovies>, SourceOfMoviesRepository>();
            services.AddTransient<IGenericRepository<Comments>, CommentsRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IMoviesGetterService<TorrentMovie>, MoviesGetterService>();
            services.AddTransient<IMovCommIndexServ, CommentIndexGetter>();
            services.AddTransient<ICommetsGetter<Comments>, CommetsGetter>();
            services.AddTransient<ISaveCommentsToDb, SaveCommentsToDb>();
            services.AddTransient<ISaveMovies, SaveMovies>();
            services.AddTransient<IAFINNService, AFINN>();
            services.AddScoped<ILemmatization, Lemmatization>();
            //services.AddSingleton<ILemmatization, Lemmatization>();
            //services.AddTransient<ILemmatization, Lemmatization>();
            services.AddTransient<ICommentHanlder, CommentHanlder>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ISaveCommentsToDb saveCommentsToDb, ISaveMovies saveMovies)
        {
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

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //Hangfire
           /* app.UseHangfireServer();
            app.UseHangfireDashboard();

            RecurringJob.AddOrUpdate(
               () => saveMovies.SaveMov(),
               Cron.Daily(5,0));*/
            

        }
    }
}
