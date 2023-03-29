using Library.DataTable.TableRole;
using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.Repository;
using Library.ServiceAdmin;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ManagerCakeOk
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
            //call connectionstring database
            services.AddDbContext<ContextDBCakeOk>(options =>
                options.UseMySQL(Configuration.GetConnectionString("DB_CakeOk")));

            services.AddRepository();
            services.AddSerivceAdmin();

            services.AddIdentity<T_User, T_Role>()
                .AddEntityFrameworkStores<ContextDBCakeOk>()
                .AddDefaultTokenProviders();

            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddControllersWithViews();

            // TODO: cookie login authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(_ =>
                {
                    _.Cookie.Name = "CakeOkLogin";
                    _.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                    _.LoginPath = new PathString("/Account/Login");
                    _.AccessDeniedPath = "/";
                    _.SlidingExpiration = true;
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
            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
