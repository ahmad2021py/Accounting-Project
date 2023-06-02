
using Accounting.DataLayer.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    [Table("Sales")]
    public class Sale : IBaseDbSet
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        [Column("Row", Order = 0)]
        public long Row { get; set; }
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleCode { get; set; }
        public string NameOfUser { get; set; }
        public string Role { get; set; }

        public string UserName { get; set; }
        public string User_Password { get; set; }
        public string ContactNo { get; set; }

        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
