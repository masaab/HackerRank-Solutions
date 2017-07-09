using AllianceInterview.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Infrastructure
{
    public abstract class Operation : IOperation
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public static Operation Find(string Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
