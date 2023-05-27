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
    [Table("Stocks")]
    public class Stock : IBaseDbSet
    {
        //-----Allways set this Column Primary Key-----
        [Key]
        //-----
        //-----set this Column auto increment To make each record unique-----
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        //-----
        public long id { get; set; }

        public DateTime StockDate { get; set; }
        public int Quantity { get; set; }
      
        public string Description { get; set; }

        public decimal BuyPrice { get; set; } //For store Money . this Type is best .

        //*********relationship************
        //---- Foreign key to Product----------
        //----This Attribute is name of Target Table---------------
        [ForeignKey("Product")]
        [Required()]
        public long FKProductId { get; set; }
        //-----
        //--------This Property is Necessary To Relationship By Product Table
        //------I Define Product Private To Not Show in each Instance----------
        public virtual Product Product { get; set; }
        //-----
        //*****

      
































        //-----------------------------------------------------
    }
}
