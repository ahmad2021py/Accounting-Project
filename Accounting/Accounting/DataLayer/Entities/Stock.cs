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
    public class Stock : IBaseDbSet
    {
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long id { get; set; }

        public DateTime StockDate { get; set; }
        public int Quantity { get; set; }

        public int TotalPrice { get; set; }
        public Product ProductId { get; set; }
    }
}
