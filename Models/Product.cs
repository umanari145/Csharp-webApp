using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Origin { get; set; }
        public DateTime HarvestDate { get; set; }
    }
}
