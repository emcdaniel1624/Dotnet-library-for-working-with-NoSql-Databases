using Microsoft.Extensions.DependencyInjection;
using NoSqlProvider.Builder;
using NoSqlProvider.Factory;
using NoSqlProvider.Providers;
using NoSqlProvider.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Shared
{
    public static class ProviderFactoryExtensions
    {
        public static IServiceCollection AddNoSqlProviderFactory(
            this IServiceCollection services,
            Func<ProviderFactoryBuilder, ProviderFactoryBuilder> builderFunc,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            var builder = builderFunc(new ProviderFactoryBuilder());
            var factory = builder.BuildFactory();
            if (factory == null) return services;
            switch (lifetime)
            {
                case ServiceLifetime.Transient:
                    services.AddTransient(x => factory);
                    break;
                case ServiceLifetime.Singleton:
                    services.AddSingleton(x => factory);
                    break;
                case ServiceLifetime.Scoped:
                    services.AddScoped(x => factory);
                    break;
                default:
                    break;
            }
            return services;
        }

        public static IServiceCollection AddNoSqlProviderFactory<TContext>(
            this IServiceCollection services,
            Func<ProviderFactoryBuilder, ProviderFactoryBuilder> builderFunc,
            ServiceLifetime lifetime = ServiceLifetime.Singleton) where TContext : Provider
        {
            var builder = builderFunc(new ProviderFactoryBuilder());
            var factory = builder.BuildFactory<TContext>();
            if(factory == null) return services;
            switch (lifetime)
            {
                case ServiceLifetime.Transient:
                    services.AddTransient(x => factory);
                    break;
                case ServiceLifetime.Singleton:
                    services.AddSingleton(x => factory);
                    break;
                case ServiceLifetime.Scoped:
                    services.AddScoped(x => factory);
                    break;
                default:
                    break;
            }
            return services;
        }
    }
}
