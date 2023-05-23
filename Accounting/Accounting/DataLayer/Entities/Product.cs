using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class Product
    {
        [Key]
        public long id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Features { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public byte[] Picture { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Company { get; set; }
    }
}
