using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditCore.BusinessLogic
{
    public class AuditItem
    {

    }

    public class Audit<T> : ICreateFindings, ICreateItems<T> where T : new()
    {
        public List<AuditItem> AuditItems { get; set; }

        public virtual void Create<T>(T auditViewModel) 
        {

        }

        public T CreateMyType()
        {
            return new T();
        }

        public virtual bool CreateItem(T item)
        {
            //pretend to save
            return true;
        }

        public virtual void CreateFindings(AuditFindingEntity finding)
        {
            
        }

        public virtual bool CreateItem(int item)
        {
            return true;
        }
    }

    public interface ICreateItems<T> where T : new()
    {
        bool CreateItem(T item);
    }

    public interface ICreateFindings
    {
        void CreateFindings(AuditFindingEntity finding);
    }
}
