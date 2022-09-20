using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using NoSqlProvider.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Factory
{
    public class MongoFactory : ProviderFactory
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public MongoFactory()
        {
            ConnectionString = "";
            DatabaseName = "";
        }

        public override MongoProvider CreateProvider()
        {
            var mongoClient = new MongoClient(ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(DatabaseName);
            var provider = new MongoProvider(mongoDatabase);
            return provider;
        }
    }


    public class MongoFactory<TContext> : ProviderFactory<TContext> where TContext : Provider
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public MongoFactory()
        {
            ConnectionString = "";
            DatabaseName = "";
        }

        public override TContext CreateProvider()
        {
            var mongoClient = new MongoClient(ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(DatabaseName);
            var provider = Activator.CreateInstance(typeof(TContext), new object[] { mongoDatabase });
            return (TContext)(provider ?? throw new Exception());
        }
    }
}
