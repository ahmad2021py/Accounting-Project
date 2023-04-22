using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
   public class Stock
    {
        [Key]
        public long StockId { get; set; }
        public int ConfigId { get; set; }

        public DateTime StockDate { get; set; }
       public int Quantity { get; set; }

        public int TotalPrice { get; set; }
    }
}
