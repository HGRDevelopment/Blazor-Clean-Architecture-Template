using HGR.Application.Abstractions;
using HGR.Infrastructure.Repositories;
using HGR.Application;
using HGR.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace HGR.WebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddApplicationLayerDependencies();
            return services;
        }
    }
}
