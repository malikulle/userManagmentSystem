using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Data.Context;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.ServiceExtension;
using EmployeeManagment.WebUI.AutoMapper.Extension;
using EmployeeManagment.WebUI.AutoMapper.Profiles;
using EmployeeManagment.WebUI.Helpers.Abstarct;
using EmployeeManagment.WebUI.Helpers.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;

namespace EmployeeManagment.WebUI
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
            services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });
            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultres = new List<CultureInfo>()
                {
                    new CultureInfo("en"),
                    new CultureInfo("tr"),
                    new CultureInfo("es"),
                    new CultureInfo("fr")
                };
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = supportedCultres;
                options.SupportedUICultures = supportedCultres;
            });

            services.LoadAutoMapperProfiles();

            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddDbContext<EmployeeManagmentContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBContext")));

            services.Configure<appSettings_json>(Configuration.GetSection("Params"));
            services.AddScoped<IImageHelper, ImageManager>();
            services.AddScoped<IMailHelper, EmailManager>();

            #region Security

            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;


                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            })
                .AddEntityFrameworkStores<EmployeeManagmentContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Identity/Account/Login");
                options.LogoutPath = new PathString("/Identity/Account/Logout");
                options.Cookie = new CookieBuilder()
                {
                    Name = "EmployeeManagment",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(7);
                options.AccessDeniedPath = new PathString("/Identity/Account/AccessDenied");
            });

            #endregion


            services.LoadEntityServices();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            //var supportedCulteres = new[] { "en", "fr", "es", "tr" };
            //var localizationOptions = new RequestLocalizationOptions()
            //    .SetDefaultCulture(supportedCulteres[0])
            //    .AddSupportedCultures(supportedCulteres)
            //    .AddSupportedUICultures(supportedCulteres);

            //app.UseRequestLocalization(localizationOptions);

            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();

                endpoints.MapAreaControllerRoute(
                    name: "Identity",
                    areaName: "Identity",
                    pattern: "Identity/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapRazorPages();
            });
        }
    }
}
