using NoSqlProvider.Providers;
using NoSqlProvider.Shared.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Entity
{
    public class DocumentSet<T> where T : Document
    {
        private List<T> _documents;
        public DocumentSet()
        {
            _documents = LoadDocs();
        }

        private List<T> LoadDocs()
        {
            throw new NotImplementedException();
        }

        public List<T> ToList()
        {
            return _documents;
        }

        public List<T> Where(Func<T,bool> query)
        {
            return _documents.Where(query).ToList();
        }

        public List<T> Add(T entity)
        {
            _documents.Add(entity);
            return _documents;
        }
    }
}
