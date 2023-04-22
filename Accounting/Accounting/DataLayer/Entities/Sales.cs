using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
  public  class Sales
    {

        [Key]
        public int SalesId { get; set; }
        public string NameOfUser { get; set; }
        public string Role { get; set; }
       
        public string UserName { get; set; }
        public string User_Password { get; set; }
        public string ContactNo { get; set; }

        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
