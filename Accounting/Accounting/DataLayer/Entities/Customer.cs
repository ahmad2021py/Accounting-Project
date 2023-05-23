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
        public int id { get; set; }
        public long NationalCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        [MaxLength(80)]
        public string City { get; set; }
        [Required]
        [MaxLength(80)]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
       

    }
}
