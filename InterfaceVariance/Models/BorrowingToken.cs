using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Models
{
    public class BorrowingToken
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string BookName { get; set; }
    }
}
