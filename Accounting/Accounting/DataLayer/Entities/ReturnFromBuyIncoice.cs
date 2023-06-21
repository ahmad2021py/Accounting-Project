using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    public class ReturnFromBuyIncoice
    {
        //----- Row Column -----
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Row { get; set; }

        //-----



        //----- Table Primary Key -----
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReturnFromBuyInvoiceCode { get; set; }


        public DateTime ReturnFromBuyInvoiceDate { get; set; }
        public int ReturnQuantity { get; set; }

        //---------- Reference to BuyInvoice ---------
        [ForeignKey("BuyInvoice")]
        [Required()]
        public string FKBuyInvoice { get; set; }
        public BuyInvoice BuyInvoice { get; set; }
        //-----



















        //-------------------

    }
}
