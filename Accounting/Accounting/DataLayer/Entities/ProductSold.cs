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
    [Table("ProductSolds")] // This Table Not Need Row Column .
    public class ProductSold 
    {
        [Key] // set this Column Primary Key
        [Required()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSoldTableCode { get; set; }
        [ForeignKey("Invoice")]
        [Required()]
        public string FKInvoice { get; set; } // This Column Must Be Uniqe . this Is FKInvoice .
        public Invoice Invoice { get; set; }
    }
}
