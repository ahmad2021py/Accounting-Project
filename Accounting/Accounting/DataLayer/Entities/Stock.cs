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




        //-----
        //-----set this Column auto increment To make each record unique-----
        [Column("Row", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //-----
        public long Row { get; set; }
        //---------------------------------------------
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockCode { get; set; } //Must be uniq at this Table
        public DateTime StockDate { get; set; }
        public int Quantity { get; set; }

        public string Description { get; set; }

        //*********relationship************
        //---- Foreign key to Product----------
        //----This Attribute is name of Target Table---------------
        [ForeignKey("Product")]
        public int FKProduct { get; set; }
        //-----
        //--------This Property is Necessary To Relationship By Product Table
        //------I Define Product Private To Not Show in each Instance----------
        public virtual Product Product { get; set; }
        //-----
        //*****





        //-----------------------------------------------------
    }


    public class StockEntityWithoutRowPropertyForUpdate
    {

        public int StockCode { get; set; }
        public DateTime StockDate { get; set; }
        public int Quantity { get; set; }

        public string Description { get; set; }

        public decimal BuyPrice { get; set; }


        public int FKProduct { get; set; }


    }



    public class StockbyOnlyQuantityField
    {

        public int Quantity { get; set; }


    }







}