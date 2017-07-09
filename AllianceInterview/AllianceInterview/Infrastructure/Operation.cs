using AllianceInterview.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Infrastructure
{
    public abstract class Operation
    {
        public virtual void Save(IOperation operation)
        {
            Person person = operation;

        }
    }
}
