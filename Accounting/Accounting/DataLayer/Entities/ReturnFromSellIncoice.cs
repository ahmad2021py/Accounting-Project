using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    public class ReturnFromSellIncoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Row { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ReturnFromSellIncoiceCode { get; set; }
        public DateTime ReturnFromSellIncoiceDate { get; set; }
        public int ReturnQuantity { get; set; }
        public decimal TotalAmountFromReturnFromSellIncoice { get; set; }
        //-------Relations---------
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
        //------FK to FKSellInvoice Table---------------
        [ForeignKey("sellInvoice")]
        public string FKSellInvoice { get; set; }
        public virtual SellInvoice sellInvoice { get; set; }
        //-----

    }
}
