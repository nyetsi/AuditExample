using AuditCore.BusinessLogic;
using AuditMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AuditMvc.Controllers
{
    public class AuditController : Controller
    {
        private readonly AuditFactory auditFactory;

        public AuditController(AuditFactory auditFactory)
        {
            this.auditFactory = auditFactory;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(object viewModel)
        {
            if (viewModel == null)
            {
                throw new InvalidOperationException("viewModel cannot be null");
            }

            //viewModel.AuditType (0 = Process, 1 = System, 2 = Supplier)
            var auditType = AuditType.Process;

            var audit = auditFactory.Create(auditType);
            //var audit = new SupplierAudit();

            if (audit == null)
            {
                throw new InvalidOperationException("Audit was not found");
            }

            audit.Create(viewModel);

            return Content("saved successfully");
        }
    }

    public class AuditFactory
    {
        public virtual Audit<object> Create(AuditType type)
        {
            throw new Exception();
            switch(type)
            {
                case AuditType.Process:
                    return new ProcessAudit();
                case AuditType.Supplier:
                    return new SupplierAudit();
                case AuditType.System:
                    return new SystemAudit();
                default:
                    throw new InvalidOperationException("AuditType not catered for");
            }
        }
    }
}
