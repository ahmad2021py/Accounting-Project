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
    [Table("Products")]
    public class Product : IBaseDbSet
    {
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long id { get; set; }
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
