using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Entity
{
    public interface IDocument
    {
        public dynamic? Id { get; set; }
    }
}
