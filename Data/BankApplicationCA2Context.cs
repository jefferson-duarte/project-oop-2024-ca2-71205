using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankApplicationCA2.Models;

namespace BankApplicationCA2.Data
{
    public class BankApplicationCA2Context : DbContext
    {
        public BankApplicationCA2Context (DbContextOptions<BankApplicationCA2Context> options)
            : base(options)
        {
        }

        public DbSet<BankApplicationCA2.Models.Customer> Customer { get; set; } = default!;
    }
}
