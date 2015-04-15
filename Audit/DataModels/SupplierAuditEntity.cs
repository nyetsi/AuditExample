using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.DataModels
{
    public class SupplierAuditEntity : AuditEntity
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
    }
}
