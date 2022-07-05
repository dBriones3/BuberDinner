using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependenciesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}
