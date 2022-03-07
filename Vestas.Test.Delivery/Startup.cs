using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Repository;
using Vestas.Test.Delivery.Application.Service;
using Vestas.Test.Delivery.Infra;
using Vestas.Test.Delivery.Infra.Repository;
using Vestas.Test.Delivery.Service;

namespace Vestas.Test.Delivery
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
            services.AddScoped<IDeliveryPointService, DeliveryPointService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDeliveryPointRepository, DeliveryPointRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(config => {
                config.CreateMap<DeliveryPoint, DeliveryPoint>();
                config.CreateMap<User, User>();
            });

            services.AddDbContext<DeliveryPointContext>(opt => {
                opt.UseMySql("Server=localhost;Port=3306;Database=vestas;Uid=vestas;Pwd=vestas;",ServerVersion.AutoDetect("Server=localhost;Port=3306;Database=vestas;Uid=vestas;Pwd=vestas;"));
            });
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Vestas.Test.Delivery", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vestas.Test.Delivery v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
