using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class ProductSold
    {
        [Key]
        public long ProductId { get; set; }
        public string Invoice { get; set; }
        public int ConfigId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int TotalAmount { get; set; }
    }
}
