using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditMvc.Models
{
    public abstract  class  AuditViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public enum AuditType
    {
        Process,
        System,
        Supplier
    }
}
