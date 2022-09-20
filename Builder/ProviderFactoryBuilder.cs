using NoSqlProvider.Factory;
using NoSqlProvider.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Builder
{
    public class ProviderFactoryBuilder : IProviderFactoryBulder
    {
        public virtual ProviderFactory? BuildFactory() { return null; }
        public virtual ProviderFactory<TContext>? BuildFactory<TContext>() where TContext : Provider { return null; }

        public MongoFactoryBuilder UseMongo(string connectionString, string databaseName)
        {
            var builder = new MongoFactoryBuilder();
            builder.SetConnectionString(connectionString);
            builder.SetDatabaseName(databaseName);
            return builder;
        }
        
        public FirestoreFactoryBuilder UseFirestore(string projectId, string privateKey)
        {
            var builder = new FirestoreFactoryBuilder();
            builder.SetProjectId(projectId);
            builder.SetPrivateKey(privateKey);
            return builder;
        }
    }
}
