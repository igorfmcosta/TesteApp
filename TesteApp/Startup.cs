using AutoMapper;
using DataAccess.Contexts;
using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Contracts;
using Domain.Services;
using Domain.Services.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteApp.Helpers;

namespace TesteApp
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
            services.AddAutoMapper(cfg => {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddEntityFrameworkSqlServer().AddDbContext<DataContext>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Main"));
            });
            services.AddTransient<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            services.AddTransient<IBaseService<Paciente>, BaseService<Paciente>>();
            services.AddTransient<IPacienteService, PacienteService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}