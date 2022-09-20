using Google.Cloud.Firestore;
using MongoDB.Bson.IO;
using NoSqlProvider.Providers;
using NoSqlProvider.Shared;
using NoSqlProvider.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NoSqlProvider.Factory
{
    public class FirestoreFactory : ProviderFactory
    {
        public string ProjectId { get; set; }
        public string PrivateKey { get; set; }

        public FirestoreFactory()
        {
            ProjectId = "";
            PrivateKey = "";
        }

        public override FirestoreProvider CreateProvider()
        {
            var settings = JsonSerializer.Serialize(new FirestoreSettings
            {
                ProjectId = ProjectId,
                PrivateKeyId = PrivateKey
            });

            var firestoreDb = new FirestoreDbBuilder
            {
                ProjectId = ProjectId,
                JsonCredentials = settings
            }.Build();

            var provider = new FirestoreProvider(firestoreDb);
            return provider;
        }
    }


    public class FirestoreFactory<TContext> : ProviderFactory<TContext> where TContext : Provider
    {
        public string ProjectId { get; set; }
        public string PrivateKey { get; set; }

        public FirestoreFactory()
        {
            ProjectId = "";
            PrivateKey = "";
        }

        public override TContext CreateProvider()
        {
            var settings = JsonSerializer.Serialize(new FirestoreSettings
            {
                ProjectId = ProjectId,
                PrivateKeyId = PrivateKey
            });

            var firestoreDb = new FirestoreDbBuilder
            {
                ProjectId = ProjectId,
                JsonCredentials = settings
            }.Build();

            var provider = Activator.CreateInstance(typeof(TContext), new object[] { firestoreDb });
            return (TContext)(provider ?? throw new Exception());
        }
    }
}
