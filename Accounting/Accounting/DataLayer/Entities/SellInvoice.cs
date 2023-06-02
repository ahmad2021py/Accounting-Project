﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    public class SellInvoice
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public int Row { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SellInvoiceCode { get; set; } //This Column Must Be Uniqe .
        public DateTime SellInvoiceDate { get; set; }




        //-------------------------
        [ForeignKey("Customer")]
        [Required()]
        public long FKCustomer { get; set; }
        public Customer Customer { get; set; }


        [ForeignKey("Stock")]
        [Required()]
        public int FKStock { get; set; }
        public Stock Stock { get; set; }


        public int Quantity { get; set; }


        public decimal TotalSellAmount { get; set; }
        public decimal SellPricePerUnit { get; set; }
        public int Off { get; set; }

    }
}
