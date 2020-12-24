using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalTest4228.Models;

namespace FinalTest4228.Data
{
    public class FinalTest4228Context : DbContext
    {
        public FinalTest4228Context (DbContextOptions<FinalTest4228Context> options)
            : base(options)
        {
        }

        public DbSet<FinalTest4228.Models.Book> Book { get; set; }

        public DbSet<FinalTest4228.Models.Client> Client { get; set; }
    }
}
