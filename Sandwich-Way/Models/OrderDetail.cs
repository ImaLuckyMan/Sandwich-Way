using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich_Way.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int SandwichId { get; set; }
        public Sandwiches Sandwich { get; set; }
        public int Amount { get; set; }
        public Order Order { get; set; }
        public decimal Price { get; set; }
    }
}
