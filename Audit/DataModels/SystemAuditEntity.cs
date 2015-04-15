using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.DataModels
{
    public class SystemAuditEntity : AuditEntity
    {
        public int Id { get; set; }
        ICollection<ElementEntity> systems { get; set; }
    }
}
