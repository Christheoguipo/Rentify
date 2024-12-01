using Microsoft.Extensions.DependencyInjection;
using Rentify.Application.MappingProfiles;
using System.Reflection;

namespace Rentify.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserProfile).Assembly);

            return services;
        }
    }
}
