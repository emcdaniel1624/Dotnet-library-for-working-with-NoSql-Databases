using NoSqlProvider.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Providers
{
    public abstract class Provider : IProvider
    {
        public abstract void Create<T>(T doc) where T : INoSqlEntity;

        public abstract Task CreateAsync<T>(T doc) where T : INoSqlEntity;

        public abstract void Delete<T>(string id) where T : INoSqlEntity;

        public abstract Task DeleteAsync<T>(string id) where T : INoSqlEntity;

        public abstract T Get<T>(string id) where T : INoSqlEntity;

        public abstract IEnumerable<T> GetAll<T>() where T : INoSqlEntity;

        public abstract Task<IEnumerable<T>> GetAllAsync<T>() where T : INoSqlEntity;

        public abstract Task<T> GetAsync<T>(string id) where T : INoSqlEntity;

        public abstract void Update<T>(string id, T doc) where T : INoSqlEntity;

        public abstract Task UpdateAsync<T>(string id, T doc) where T : INoSqlEntity;
    }
}
