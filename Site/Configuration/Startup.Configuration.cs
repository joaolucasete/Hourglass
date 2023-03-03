namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigurationServiceCollectionExtensions
{
    private const string General = "General";

    public static IServiceCollection AddAppConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<AppGeneralConfig>(configuration.GetSection(General));

        return services;
    }
}
