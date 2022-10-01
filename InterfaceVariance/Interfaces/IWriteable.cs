using InterfaceVariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Interfaces
{
    interface IWriteable<in T>
    {
        void Save(T value);
        void Delete(T value);
        void Update(T value, params ParamObject[] values);
    }
}
