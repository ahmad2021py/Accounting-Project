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
    public class Registration : IBaseDbSet
    {
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long id { get; set; }
        //-------UserName and Password and Role----
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //-----Some Personality Informations----
        public string Name { get; set; }
        public string Family { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public DateTime JoiningDate { get; set; }

        public byte[] Avatar { get; set; }
    }
}
