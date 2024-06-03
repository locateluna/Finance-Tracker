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
    }
}
