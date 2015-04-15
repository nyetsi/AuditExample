using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditCore.BusinessLogic
{
    public class AuditFindingEntity
    {
        public int Id { get; set; }
        public int AuditId { get; set; }
        public string Description { get; set; }
    }
}
