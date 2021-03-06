using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class TourDbContext : DbContext
    {
        public TourDbContext (DbContextOptions<TourDbContext> options) : base (options)
        { }

        public DbSet <Tour> Tours { get; set; }

        public DbSet <TourGroup> TourGroups { get; set; }
    }
}
