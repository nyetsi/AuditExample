using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.BusinessLogic
{
    public class ProcessAudit : Audit<object>
    {
        public override void Create<ProcessAudit>(ProcessAudit auditViewModel)
        {
            //throw new NotImplementedException();
        }

        public override bool CreateItem(object item)
        {

            var result = this.CreateItem(item);
            return result;
        }

        public void CreateFindings(AuditFindingEntity finding)
        {
            //throw new NotImplementedException();
        }
    }
}
