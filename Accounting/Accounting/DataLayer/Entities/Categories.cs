using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class Categories
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }







    }
}
