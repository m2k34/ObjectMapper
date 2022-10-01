using InterfaceVariance.Interfaces;
using InterfaceVariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Objects
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        public abstract void Delete(T value);
        public abstract T Read(params ParamObject[] args);

        public abstract void Save(T value);

        public virtual void Update(T value, params ParamObject[] values)
        {
            Delete(value);
            ObjectMapper.Map(value, values);
            Save(value);
        }

    }
}
