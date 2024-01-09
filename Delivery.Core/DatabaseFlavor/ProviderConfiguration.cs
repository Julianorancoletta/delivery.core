using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;

namespace Delivery.Core.DatabaseFlavor;
public class ProviderConfiguration
{
    private readonly string _connectionString;
    public static ProviderConfiguration With;
    private static readonly string MigrationAssembly = typeof(ProviderConfiguration).GetTypeInfo().Assembly.GetName().Name;

    public static void Build(string connString)
    {
        if (With is null)
        {
            With = new ProviderConfiguration(connString);
        }
    }

    public ProviderConfiguration(string connString) => _connectionString = connString;

    public Action<DbContextOptionsBuilder> SqlServer =>
        options => options.UseNpgsql(_connectionString);


    public static string DetectDatabase(IConfiguration configuration) => (configuration.GetConnectionString("DefaultConnection"));
}
