using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Car2Go.Data;
using Car2Go.Data.Common;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Data.Repositories;
using Car2Go.Data.Seeding;
using Car2Go.Services;
using Car2Go.Services.Data;
using Car2Go.Services.Mapping;
using Car2Go.Web.ViewModels;

namespace Car2Go.Web
{

    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<CookiePolicyOptions>(
                options =>
                {
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });

            services.AddControllersWithViews(
                options =>
                {
                    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                }).AddRazorRuntimeCompilation();
            services.AddRazorPages();

            services.AddSingleton(this.configuration);

            // Config Cloud Storage
            //Account account = new Account(
            //    this.configuration["Cloudinary:AppName"],
            //    this.configuration["Cloudinary:AppName"],
            //    this.configuration["Cloudinary:AppName"]);

            //Cloudinary cloudinary = new Cloudinary(account);

            //services.AddSingleton(cloudinary);

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            // services.AddTransient<IUserStore<ApplicationUser>, ApplicationUserStore>();
            // services.AddTransient<IRoleStore<ApplicationRole>, ApplicationRoleStore>();
            services.AddTransient<ILocationsService, LocationsService>();
            services.AddTransient<ICarsService, CarsService>();
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IUsersService, UsersService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            // Seed data on application startup
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
                new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(
                endpoints =>
                {
                    endpoints.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapControllerRoute("default", "{controller=Cars}/{action=All}/{searchTerm?}");
                    endpoints.MapControllerRoute("default", "{controller=Cars}/{action=Available}/{searchTerm?}");
                    endpoints.MapRazorPages();
                });
        }
    }
}
