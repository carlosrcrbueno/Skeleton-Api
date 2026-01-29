using Microsoft.Extensions.DependencyInjection;

namespace Skeleton.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register application services, handlers, validators, etc.
        return services;
    }
}
