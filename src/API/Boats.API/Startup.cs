using Boats.Api.Mapping;
using Boats.Services.Contract;
using Boats.Data;
using Boats.Data.Contract.Repositories;
using Boats.Data.Repositories;
using Boats.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Boats.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<BoatsContext>(options =>
            {
                options.UseSqlServer(_configuration.GetConnectionString("BoatsDataStore"));
            });
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Boats", Version = "v1" });
            });

            services.AddAutoMapper(typeof(BoatProfile));

            // Data
            services.AddTransient<IBoatRepository, BoatRepository>();

            // Services
            services.AddTransient<IBoatService, BoatService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BoatsContext boatsContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Boats v1"));
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Setup database
            boatsContext.Database.Migrate();

            if (env.IsDevelopment())
            {
                Seeder.EnsureSeededAsync(boatsContext).Wait();
            }
        }
    }
}
