using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich_Way.Models
{
    public interface ISandwichRepository
    {
        IEnumerable<Sandwiches> GetAllSandwiches { get; }
        IEnumerable<Sandwiches> GetSandwichOnSale { get; }
        Sandwiches GetSandwichesById(int sandwichId);
    }
}
