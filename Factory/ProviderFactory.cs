using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoSqlProvider.Providers;

namespace NoSqlProvider.Factory
{
    public abstract class ProviderFactory<TContext> where TContext : Provider
    {
        public abstract TContext CreateProvider();
    }
    
    public abstract class ProviderFactory
    {
        public abstract Provider CreateProvider();
    }
}
