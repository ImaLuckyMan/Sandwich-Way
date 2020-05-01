using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich_Way.Models
{
    public class Sandwiches
    {
        [Key]
        public int SandwichId { get; set;}
        public string SandwichName { get; set;}
        public string Description { get; set;}
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
