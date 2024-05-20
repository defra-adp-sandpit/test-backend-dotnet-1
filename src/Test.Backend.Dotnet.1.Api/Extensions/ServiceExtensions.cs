using Test.Backend.Dotnet.1.Core.Interfaces;
using Test.Backend.Dotnet.1.Core.Services;

namespace Test.Backend.Dotnet.1.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
