using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Infrastructure
{
    public interface IOperation
    {
        string Id { get; set; }
        void Save();
        void Delete();
        void Find();
    }
}
