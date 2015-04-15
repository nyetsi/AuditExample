using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.BusinessLogic
{
    public class Element
    {

    }

    public class SystemAudit : Audit<object>
    {
        public List<Element> Elements { get; set; }

        public override void Create<SystemAudit>(SystemAudit auditViewModel)
        {
            throw new NotImplementedException();
        }

        //public override void CreateFindings(AuditFindingEntity finding)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
