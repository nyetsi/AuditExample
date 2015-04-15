using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.DataModels
{
    public abstract class AuditEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
