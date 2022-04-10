using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class HeroContext : DbContext
    {
        public DbSet<Core.Entities.Hero> Heroes { get; set; }
        public HeroContext(DbContextOptions<HeroContext> contextOptions) : base(contextOptions) { }
    }
}
