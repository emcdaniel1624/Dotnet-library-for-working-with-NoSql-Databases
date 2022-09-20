using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Providers
{
    public class FirestoreProvider : Provider
    {
        private FirestoreDb _firestoreDb;

        public FirestoreProvider(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public override void Create<T>(T doc)
        {
            throw new NotImplementedException();
        }

        public override Task CreateAsync<T>(T doc)
        {
            throw new NotImplementedException();
        }

        public override void Delete<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override T Get<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<T>> GetAllAsync<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<T> GetAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override void Update<T>(string id, T doc)
        {
            throw new NotImplementedException();
        }

        public override Task UpdateAsync<T>(string id, T doc)
        {
            throw new NotImplementedException();
        }
    }
}
