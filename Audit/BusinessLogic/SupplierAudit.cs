using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.BusinessLogic
{
    public class SupplierAudit : Audit<object>
    {
        public override void Create<SupplierAudit>(SupplierAudit auditViewModel)
        {
            //throw new NotImplementedException();
        }

        public override bool CreateItem(object item)
        {
            //ignore the item, because we dont' save them for supplier
            return true;
        }

        //public override void CreateFindings(AuditFindingEntity finding)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
