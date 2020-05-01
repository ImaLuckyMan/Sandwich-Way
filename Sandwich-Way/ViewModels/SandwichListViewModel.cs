using Sandwich_Way.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich_Way.ViewModels
{
    public class SandwichListViewModel
    {
        public IEnumerable<Sandwiches> Sandwiches { get; set; }
        public string CurrentCategory { get; set; }
    }
}
