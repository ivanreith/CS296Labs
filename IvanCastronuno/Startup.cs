using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IvanCastronuno.Models;
using IvanCastronuno.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IvanCastronuno
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
           /* services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });
            services.AddMvc();  */
            // Injecting the repositories into the controllers.

            services.AddTransient<IStories, StoriesRepository>(); // repository Interface then repo class
            //services.AddTransient<UserRepository, UsersRepository>();


            services.AddControllersWithViews();
            services.AddDbContext<StoryContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("StoryContext")));
            // Stuff added for Identity
            services.AddIdentity<AppUser, IdentityRole>()
             .AddEntityFrameworkStores<StoryContext>()
             .AddDefaultTokenProviders();
            //End identity stuff

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
            app.UseAuthentication(); // ADDED for indentity
            app.UseAuthorization();
            StoryContext.CreateAdminUser(app.ApplicationServices).Wait();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
            });
        }
    }
}
