using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETD3202_Lab5.Models;

//Make sure the following packages are installed via the nu get package manager
using Microsoft.EntityFrameworkCore.SqlServer;


namespace NETD3202_Lab5
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
            //Default.
            services.AddControllersWithViews();
            //Added by me.
            services.AddRazorPages();
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //Make sure you use the Nu-Get Package manager to install: Microsoft.EntityFrameworkCore.SqlServer, otherwise the following line of code will not work.
            //These lines of code are added AFTER you have creater the model and the dbcontext.
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            // Adding connection to the database.
            string connection = @"Server=(localdb)\mssqllocaldb;Database=NETD3202_Lab5;Trusted_Connection=True;ConnectRetryCount=0";

            // Adding Db Context
            services.AddDbContext<recipeContext>(options => options.UseSqlServer(connection));

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
