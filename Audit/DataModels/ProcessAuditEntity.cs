using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditCore.DataModels;

namespace AuditCore.DataModels
{
    public class ProcessAuditEntity : AuditEntity
    {
        public int Id { get; set; }
        public int CellId { get; set; }
    }
}
