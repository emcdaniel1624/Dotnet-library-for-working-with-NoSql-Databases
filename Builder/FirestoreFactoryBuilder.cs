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
    public class FirestoreFactoryBuilder : ProviderFactoryBuilder
    {
        private string? ProjectId;
        private string? PrivateKey;

        internal void SetProjectId(string projectId)
        {
            ProjectId = projectId;
        }

        internal void SetPrivateKey(string privateKey)
        {
            PrivateKey = privateKey;
        }

        public override FirestoreFactory BuildFactory()
        {
            var factory = new FirestoreFactory();
            factory.ProjectId = ProjectId ?? throw new Exception();
            factory.PrivateKey = PrivateKey ?? throw new Exception();
            return factory;
        }

        public override FirestoreFactory<TContext> BuildFactory<TContext>()
        {
            var factory = new FirestoreFactory<TContext>();
            factory.ProjectId = ProjectId ?? throw new Exception();
            factory.PrivateKey = PrivateKey ?? throw new Exception();
            return factory;
        }
    }
}
