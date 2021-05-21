using Base.Providers;
using Base.Providers.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Base
{
    public static class DiConfig
    {
        public static IServiceCollection UseBase(this IServiceCollection service)
        {
            return service.AddScoped<ISqlConnectionProvider, SqlConnectionProvider>();
        }
    }
}