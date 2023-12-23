using Microsoft.Extensions.DependencyInjection;
using Users.Application.Services;

namespace Users.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection collection)
    {
        collection.AddTransient<IUserService, UserService>();
        return collection;
    }
}