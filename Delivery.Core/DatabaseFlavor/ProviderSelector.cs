using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static Delivery.Core.DatabaseFlavor.ProviderConfiguration;

namespace Delivery.Core.DatabaseFlavor;

public static class ProviderSelector
{
    public static IServiceCollection ConfigureProviderForContext<TContext>(this IServiceCollection services, string options) where TContext : DbContext
    {
        var connString = options;
        Build(connString);
        return services.PersistStore<TContext>(With.SqlServer);
    }
}