using NoSqlProvider.Providers;

namespace NoSqlProvider.Factory
{
    public interface IProviderFactory<TContext> where TContext : Provider
    {
        public TContext CreateProvider();
    }
}