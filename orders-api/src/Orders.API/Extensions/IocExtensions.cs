using MediatR;

namespace Orders.API.Extensions;

public static class IocExtensions
{
    public static void AddIoc(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        
    }
}
