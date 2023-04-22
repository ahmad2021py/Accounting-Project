using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class Config
    {
        [Key]
        public int ConfigId { get; set; }
        public string ProductName { get; set; }
        public string Features { get; set; }

        public float Price { get; set; }
    }
}
