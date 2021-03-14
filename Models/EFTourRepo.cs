using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class EFTourRepo : ITourRepo
    {
        private TourDbContext _context;

        public EFTourRepo(TourDbContext context)
        {
            _context = context;
        }

        public IQueryable<Tour> Tours => _context.Tours;
    }
}
