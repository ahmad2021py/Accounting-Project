using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    public class BuyInvoice
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public int Row { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string BuyInvoiceCode { get; set; } //This Column Must Be Uniqe .
        public DateTime BuyInvoiceDate { get; set; }

        public int BuyCount { get; set; }

        public decimal BuyPricePerUnit { get; set; }
        public int Off { get; set; }

        public decimal TotalBuyAmount { get; set; }

        [ForeignKey("Seller")]
        [Required()]
        public long FKSeller { get; set; }
        public Seller Seller { get; set; }


        [ForeignKey("Stock")]
        [Required()]
        public int FKStock { get; set; }
        public Stock Stock { get; set; }

    }
}
