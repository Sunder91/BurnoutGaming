using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BurnoutGaming.Models;

namespace BurnoutGaming.Data
{
    public class BurnoutGamingContext : DbContext
    {
        public BurnoutGamingContext (DbContextOptions<BurnoutGamingContext> options)
            : base(options)
        {
        }

        public DbSet<BurnoutGaming.Models.Members> Members { get; set; }
    }
}
