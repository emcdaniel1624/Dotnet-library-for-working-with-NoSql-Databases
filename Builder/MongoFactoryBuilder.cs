using NoSqlProvider.Factories;
using NoSqlProvider.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Builder
{
    public class MongoFactoryBuilder : ProviderFactoryBuilder
    {
        private string? ConnectionString;
        private string? DatabaseName;

        internal void SetConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }

        internal void SetDatabaseName(string databaseName)
        {
            DatabaseName = databaseName;
        }

        public override MongoFactory BuildFactory()
        {
            var factory = new MongoFactory();
            factory.ConnectionString = ConnectionString ?? throw new Exception();
            factory.DatabaseName = DatabaseName ?? throw new Exception();
            return factory;
        }
        
        public override MongoFactory<TContext> BuildFactory<TContext>()
        {
            var factory = new MongoFactory<TContext>();
            factory.ConnectionString = ConnectionString ?? throw new Exception();
            factory.DatabaseName = DatabaseName ?? throw new Exception();
            return factory;
        }
    }
}
