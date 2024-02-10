using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application
{
    public static class DependencyInjection
    {
        //TODO: Add DI + mediatr etc here, ...
        public static IServiceCollection AddApplicationLayerDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}
