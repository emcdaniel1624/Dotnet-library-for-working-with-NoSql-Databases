using NoSqlProvider.Providers;
using NoSqlProvider.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Entity
{
    public static class DocumentSetExtensions
    {
        public static List<TType> ToList<TType>(this Provider provider) where TType : INoSqlEntity
        {
            var retVal = provider.GetAll<TType>();
            return retVal.ToList();
        }
    }
}
