using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Business.Concrete;
using TravelShuttle.Core;
using TravelShuttle.Core.Entities;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.DataAccess.Concrete.EntityFramework;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.WebUI.MiddleWares;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IGlobalVariable, GlobalVariable>();

            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<ICarDal, EfCarDal>();

            services.AddTransient<IDefinitionService, DefinitionManager>();
            services.AddTransient<IDefinitionDal, EfDefinitionDal>();

            services.AddScoped<IPageService, PageManager>();
            services.AddScoped<IPageDal, EfPageDal>();

            services.AddScoped<ITagService, TagManager>();
            services.AddScoped<ITagDal, EfTagDal>();

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();

            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();

            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IImageDal, EfImageDal>();

            services.AddTransient<WebFunctions>();

            services.AddMvc(option => option.EnableEndpointRouting = false);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             if (env.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();
             }

            app.UseStaticFiles();
            app.UseStaticFilePath(env.ContentRootPath, new string[] { "WebFiles"});

            app.UseMvcWithDefaultRoute();
            app.UseMvc(c => RouteConfig.Use(c));
        }
    }
}
