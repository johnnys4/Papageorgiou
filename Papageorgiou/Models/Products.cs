using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Papageorgiou.Models
{
    public class Products
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public Boolean Enabled { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public double x { get; set; }
        [Required]
        public double y { get; set; }
        [Required]
        public double z { get; set; }
        [Required]
        public string ImgLink { get; set; }
        [Required]
        public Boolean Featured { get; set; }
    }
}
