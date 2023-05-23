using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(400)]
        public string Address { get; set; }
        [Required]
        [MaxLength(80)]
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        [Required]
        public int Phone { get; set; }
        public string Email { get; set; }

    }
}
