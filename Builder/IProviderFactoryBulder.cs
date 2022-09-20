using NoSqlProvider.Factory;
using NoSqlProvider.Providers;

namespace NoSqlProvider.Builder
{
    public interface IProviderFactoryBulder
    {
        public abstract ProviderFactory? BuildFactory();
        public abstract ProviderFactory<TContext>? BuildFactory<TContext>() where TContext : Provider;
        public MongoFactoryBuilder UseMongo(string connectionString, string databaseName);
        public FirestoreFactoryBuilder UseFirestore(string projectId, string privateKey);
    }
}