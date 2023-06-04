using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    public class ReturnFromSellIncoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public int Row { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ReturnFromSellIncoiceCode { get; set; } //This Column Must Be Uniqe .
        public DateTime ReturnFromSellIncoiceDate { get; set; }




        //--------FK To Customer Table-----------------
        [ForeignKey("Customer")]
        [Required()]
        public long FKCustomer { get; set; }
        public Customer Customer { get; set; }
        //-----

        //-------FK To Stock Table ----------------
        [ForeignKey("Stock")]
        [Required()]
        public int FKStock { get; set; }
        public Stock Stock { get; set; }
        //-----

        //------FK to ProductSold Table---------------
        [ForeignKey("ProductSold")]
        public int? FKProductSold { get; set; }

        public ProductSold ProductSold { get; set; }

        //-----

        public int ReturnQuantity { get; set; }


        public decimal TotalAmountFromReturnFromSellIncoice { get; set; }


        //----------------------
    }
}
