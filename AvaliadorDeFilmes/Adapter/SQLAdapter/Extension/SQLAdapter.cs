using AvaliadorDeFilmes.Adapter.SQLAdapter.Models;
using AvaliadorDeFilmes.Adapter.SQLAdapter.Models.Connection;
using AvaliadorDeFilmes.Adapter.SQLAdapter.Repository;

namespace AvaliadorDeFilmes.Adapter.SQLAdapter.Extension
{
    public static class SQLAdapter
    {
        public static IServiceCollection AddSQLAdapter(this IServiceCollection services)
        {

            IConfiguration configuration = new ConfigurationBuilder()
              .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
              .Build();

            services.Configure<ConnectionString>(options => configuration.GetSection("SQLDBConnection").Bind(options));
            services.AddSingleton<SQLDbContext>();
            services.AddScoped<Irepository, Repositorys>();
            return services;
        }
    }
}
