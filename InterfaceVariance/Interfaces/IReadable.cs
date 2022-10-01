using InterfaceVariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Interfaces
{
    interface IReadable<out T>
    {
        T Read(params ParamObject[] args);
    }
}
