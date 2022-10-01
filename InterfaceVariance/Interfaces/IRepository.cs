using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Interfaces
{
    interface IRepository<T>: IReadable<T>, IWriteable<T>
    {
       
    }
}
