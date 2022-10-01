using InterfaceVariance.Context;
using InterfaceVariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Objects
{
    public class SQLRepository : GenericRepository<BorrowingToken>
    {
        private BorrowingTokenContext _context;
        public SQLRepository(BorrowingTokenContext context)
        {
            _context = context;
        }
        public override void Delete(BorrowingToken value)
        {
            _context.Remove(value);
            _context.SaveChanges();

        }

        public override BorrowingToken Read(params ParamObject[] args)
        {
            var obj = new BorrowingToken();
            ObjectMapper.Map(obj, args);
            return _context.borrowingTokens.FirstOrDefault(x => x.Id == obj.Id);
        }

        public override void Save(BorrowingToken value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        public override void Update(BorrowingToken value, params ParamObject[] values)
        {
            ObjectMapper.Map(value, values);
            _context.Update(value);
            _context.SaveChanges();
        }
    }
}
