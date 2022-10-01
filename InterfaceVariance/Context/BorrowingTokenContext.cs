using InterfaceVariance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVariance.Context
{
    public class BorrowingTokenContext : DbContext
    {
        public DbSet<BorrowingToken> borrowingTokens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NS6G27F;Database=BookingTokenDB;Trusted_Connection=True");
        }
    }
}
