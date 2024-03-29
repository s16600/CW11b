using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW11.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CW11
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
            services.AddDbContext<DoctorDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16600;Integrated Security=True");
            });

            services.AddDbContext<MedicamentDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16600;Integrated Security=True");
            });

            services.AddDbContext<PatientDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16600;Integrated Security=True");
            });

            services.AddDbContext<PrescriptionDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16600;Integrated Security=True");
            });

            services.AddDbContext<Prescription_MedicamentDbContext>(options =>
            {
                options.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16600;Integrated Security=True");
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
