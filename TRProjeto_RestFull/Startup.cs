using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TRProjeto_RestFull.Business;
using TRProjeto_RestFull.Business.Implementation;
using TRProjeto_RestFull.Model.Context;
using TRProjeto_RestFull.Repository;
using TRProjeto_RestFull.Repository.Generic;

namespace TRProjeto_RestFull
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

            services.AddControllers();

            services.AddScoped<IClienteBusiness, ClienteBusinessImplementation>();
            services.AddScoped(typeof(IRepository<>), typeof(IClienteBusiness<>));

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            services.AddDbContext<MYSQLContext>(options => options.UseMySql(connection, ServerVersion.Parse("8.0.31 - mysql")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TRProjeto_RestFull", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TRProjeto_RestFull v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
