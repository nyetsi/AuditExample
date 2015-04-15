using AuditCore.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var audit = new Audit<object>();
            var value = audit.CreateMyType();
        }
    }

    public class Special
    {
        public Special()
        {

        }
    }
}
