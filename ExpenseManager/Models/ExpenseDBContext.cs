using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class ExpenseDBContext : DbContext
    {
        public ExpenseDBContext()
        {
        }

        public ExpenseDBContext(DbContextOptions<ExpenseDBContext> options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ExpenseReportDB;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }



        public virtual DbSet<ExpenseReport> ExpenseReport { get; set; }
    }
}
