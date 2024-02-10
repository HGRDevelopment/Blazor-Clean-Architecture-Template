using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayerDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<DummyDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
