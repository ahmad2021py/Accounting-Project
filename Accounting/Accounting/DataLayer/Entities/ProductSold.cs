using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    [Table("ProductSolds")] // This Table Not Need Row Column .
    public class ProductSold
    {



        [Key] // set this Column Primary Key
        [Required()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSoldTableCode { get; set; }



        //--------FK to SellInvoice-------------
        [ForeignKey("SellInvoice")]
        [Required()]
        public string FKSellInvoice { get; set; } // This Column Must Be Uniqe . this Is FKInvoice .
        public SellInvoice SellInvoice { get; set; }





    }
}
