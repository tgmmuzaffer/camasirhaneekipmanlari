using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Repository;
using Web.Repository.IRepository;

namespace Web.Extensions
{
    public static class RepoExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<ISliderRepo, SliderRepo>();
            services.AddScoped<IFeatureDescriptionRepo, FeatureDescriptionRepo>();
            services.AddScoped<IFeatureRepo, FetureRepo>();
            services.AddScoped<IAboutUsRepo, AboutUsRepo>();
            services.AddScoped<IContactRepo, ContactRepo>();
            services.AddScoped<IBlogRepo, BlogRepo>();
            services.AddScoped<IReferanceRepo, ReferanceRepo>();

        }
    }
}
