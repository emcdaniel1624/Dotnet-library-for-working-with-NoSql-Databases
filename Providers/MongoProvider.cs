using Google.Cloud.Firestore;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Providers
{
    public class MongoProvider : Provider
    {
        private IMongoDatabase _mongoDatabase;

        public MongoProvider(IMongoDatabase mongoDb)
        {
            _mongoDatabase = mongoDb;
        }

        public override IEnumerable<T> GetAll<T>()
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s").AsQueryable();
            return collection;
        }

        public override T Get<T>(string id)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            var retVal = collection.Find(Builders<T>.Filter.Eq("id", id)).FirstOrDefault();
            return retVal;
        }

        public override async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s").AsQueryable();
            return await collection.ToListAsync();
        }

        public override async Task<T> GetAsync<T>(string id)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            var retVal = await collection.Find(Builders<T>.Filter.Eq("id", id)).FirstOrDefaultAsync();
            return retVal;
        }

        public override void Create<T>(T doc)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            collection.InsertOne(doc);
        }

        public override async Task CreateAsync<T>(T doc)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            await collection.InsertOneAsync(doc);
        }

        public override void Update<T>(string id, T doc)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            collection.ReplaceOne(Builders<T>.Filter.Eq("id", id), doc);
        }

        public override  async Task UpdateAsync<T>(string id, T doc)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            await collection.ReplaceOneAsync(Builders<T>.Filter.Eq("id", id), doc);
        }

        public override void Delete<T>(string id)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            collection.DeleteOne(x => x.Id == id);
        }

        public override async Task DeleteAsync<T>(string id)
        {
            var collection = _mongoDatabase.GetCollection<T>($"{typeof(T).Name}s");
            await collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
