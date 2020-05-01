using System;
using Sandwich_Way.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich_Way.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sandwiches> SandwichOnSale { get; set; }
    }
}
