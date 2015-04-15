using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditMvc.Models
{
    public class ProcessAuditViewModel : AuditViewModel
    {
        public int ProcessId { get; set; }
        public IList<CellViewModel> Processes { get; set; }
    }
}
