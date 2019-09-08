using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BillGenerator.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using BillGenerator.Domain;
using BillGenerator.Repository;
using BillGenerator.Services.Interfaces;
using BillGenerator.Business;
using BillGenerator.Business.Interfaces;
using BillGenerator.Services;
using BillGenerator.Repository.Interfaces;


namespace BillGenerator
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
            DependencyInjection(services);

           services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Bill Generator",
                        Version = "v1",
                        Description = "A micro-service that calculates the customer account value.",
                        Contact = new Contact
                        {
                            Name = "Only R - Only Research",
                            Url = "https://github.com/onlyresearch"
                        }
                    }
                    );

                var caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var nomeAplicacao =
                    PlatformServices.Default.Application.ApplicationName;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }

        public void DependencyInjection(IServiceCollection services)
        {
            services.AddSingleton<ICustomerBillRepository, CustomerBillRepository>();
            services.AddTransient<ICustomerBillServices, CustomerBillService>();
            services.AddTransient<ICustomerBillBusiness, CustomerBillBusiness>();
            
        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bill Generator");
                c.RoutePrefix = string.Empty;
            });


        }
    }
}
