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
     
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long Row { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key] // set this Column Primary Key
        public long NationalCode { get; set; } //There is no need for the Customer Code column because the national code is unique .
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }
 
        [MaxLength(80)]
        public string City { get; set; }
 
        [MaxLength(80)]
        public string State { get; set; }
  
        public string ZipCode { get; set; }
    
        public string Phone { get; set; }
        public string Email { get; set; }

        public decimal debtor { get; set; }
        public decimal creditor { get; set; }

    }
}
