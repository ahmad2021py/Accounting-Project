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
    [Table("Sales")]
    public  class Sale : IBaseDbSet
    {

        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long id { get; set; }
        public string NameOfUser { get; set; }
        public string Role { get; set; }
       
        public string UserName { get; set; }
        public string User_Password { get; set; }
        public string ContactNo { get; set; }

        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
