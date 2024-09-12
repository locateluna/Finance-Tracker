using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finance_Tracker.Models;

namespace Finance_Tracker.Data
{
    public class Finance_TrackerContext : DbContext
    {
        public Finance_TrackerContext (DbContextOptions<Finance_TrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Finance_Tracker.Models.Account> Account { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.Saving> Saving { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.Investment> Investment { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.Debt> Debt { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.CreditCard> CreditCard { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.Budget> Budget { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.Transaction> Transaction { get; set; } = default!;
        public DbSet<Finance_Tracker.Models.Graph> Graph
        { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Finance_Tracker.Models.Account>().ToTable("Account");
            modelBuilder.Entity<Finance_Tracker.Models.Saving>().ToTable("Saving");
            modelBuilder.Entity<Finance_Tracker.Models.Investment>().ToTable("Investment");
            modelBuilder.Entity<Finance_Tracker.Models.Debt>().ToTable("Debt");
            modelBuilder.Entity<Finance_Tracker.Models.CreditCard>().ToTable("CreditCard");
            modelBuilder.Entity<Finance_Tracker.Models.Budget>().ToTable("Budget");
            modelBuilder.Entity<Finance_Tracker.Models.Graph>().ToTable("Graph");

        }
    }
}
