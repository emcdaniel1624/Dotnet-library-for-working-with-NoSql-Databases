using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlProvider.Entity
{
    public class Document : IDocument
    {
        public virtual dynamic? Id { get; set; }
    }
}
