using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Infrastructure
{
    public interface IDataOperation
    {
        void Save();

        void Delete();
    }
}
