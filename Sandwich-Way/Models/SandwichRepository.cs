using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sandwich_Way.Models
{
    public class SandwichRepository : ISandwichRepository
    {
        private readonly AppDbContext _appDbContext;

        public SandwichRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable <Sandwiches> GetAllSandwiches 
        {
            get
            {
                return _appDbContext.Sandwiches.Include(s => s.Category);
            }
        }

        public IEnumerable<Sandwiches> GetSandwichOnSale
        {
            get
            {
                return _appDbContext.Sandwiches.Include(s => s.Category).Where(s => s.IsOnSale);
            }
        }

        public Sandwiches GetSandwichesById(int sandwichId)
        {
            return _appDbContext.Sandwiches.FirstOrDefault(s => s.SandwichId == sandwichId);
        }
    }
}
