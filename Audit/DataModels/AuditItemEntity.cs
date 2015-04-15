using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditCore.BusinessLogic
{
    public class AuditItemEntity
    {
        public int Id { get; set; }
        public int AuditId { get; set; }
        public string Task { get; set; }
        public DateTime Time { get; set; }
    }
}
