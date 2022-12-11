using DevTubeCommerce.Application.Contract.Interfaces.Catalog;
using DevTubeCommerce.Application.Services.Catalog;
using Microsoft.Extensions.DependencyInjection;

namespace DevTubeCommerce.Application;

public static class ApplicationServiceSetup
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IFeatureService, FeatureService>();
    }
}
