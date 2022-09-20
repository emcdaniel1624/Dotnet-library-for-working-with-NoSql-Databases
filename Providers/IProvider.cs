using NoSqlProvider.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Providers
{
    public interface IProvider
    {
        public IEnumerable<T> GetAll<T>() where T : INoSqlEntity;
        public T Get<T>(string id) where T : INoSqlEntity;
        public Task<IEnumerable<T>> GetAllAsync<T>() where T : INoSqlEntity;
        public Task<T> GetAsync<T>(string id) where T : INoSqlEntity;
        public void Create<T>(T doc) where T : INoSqlEntity;
        public Task CreateAsync<T>(T doc) where T : INoSqlEntity;
        public void Update<T>(string id, T doc) where T : INoSqlEntity;
        public Task UpdateAsync<T>(string id, T doc) where T : INoSqlEntity;
        public void Delete<T>(string id) where T : INoSqlEntity;
        public Task DeleteAsync<T>(string id) where T : INoSqlEntity;
    }
}
