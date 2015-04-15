using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditMvc.Models
{
    public class SystemAuditViewModel:AuditViewModel
    {
        public int Id { get; set; }
        public int PlantId  { get; set; }
        public IList<ElementViewModel> Elements { get; set; }
    }
}
