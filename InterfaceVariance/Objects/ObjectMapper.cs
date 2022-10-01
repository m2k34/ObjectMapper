using InterfaceVariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Objects
{
    public static class ObjectMapper
    {
        public static void Map<T>(T obj, params ParamObject[] args) where T : class
        {
            var members = obj.GetType().GetProperties();

            foreach (var member in members)
            {
                try
                {
                    var val = args.First(x => x.type == member.PropertyType && x.name.ToLower() == member.Name.ToLower()).value;
                    member.SetValue(obj, Convert.ChangeType(val, member.PropertyType), null);
                }
                catch { }

            }
        }
    }
}
