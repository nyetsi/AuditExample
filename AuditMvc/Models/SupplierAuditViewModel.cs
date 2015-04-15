using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditMvc.Models
{
    public class SupplierAuditViewModel : AuditViewModel
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public IList<SupplierViewModel> Suppliers { get; set; }
    }
}
