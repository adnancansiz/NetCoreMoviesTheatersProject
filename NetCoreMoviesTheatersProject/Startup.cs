using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Repositories;
using NetCoreMoviesTheatersProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllersWithViews();

            services.AddDbContext<MovieTheaterDb>(x => x.UseSqlServer("Server=DESKTOP-QR4J7JA\\SQLEXPRESS;Database=MovieTheaterDb;Trusted_Connection=True;"));

            services.AddTransient<ICategoryRepository, CategoryService>();
            services.AddTransient<IMovieRepository, MovieService>();
            services.AddTransient<ISaloonRepository, SaloonService>();
            services.AddTransient<ISessionRepository, SessionService>();
            services.AddTransient<IWeekRepository, WeekService>();
            services.AddTransient<ITheaterRepository, TheaerService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(x =>
            {
                x.MapControllerRoute(
                    name: "defaul",
                    pattern: "{Controller=Home}/{Action=Index}/{id?}"
                    );
            });

            
        }
    }
}
