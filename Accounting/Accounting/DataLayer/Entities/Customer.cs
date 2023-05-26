using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    [Table("Customers")] // this attribute is name of table 
    public class Customer : IBaseDbSet
    {
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long id { get; set; }
        [Required]

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
