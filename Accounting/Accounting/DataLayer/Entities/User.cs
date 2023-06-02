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
    [Table("Users")]
    public class User : IBaseDbSet
    {
        [Column("Row", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long Row { get; set; }



        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("UserCode", Order = 1)]
        public int UserCode { get; set; } //This Column Must Be Uniqe .



        [Column("Role", Order = 2)]
        public string Role { get; set; }



        [StringLength(50)]
        [Column("UserName", Order = 3)]
        public string UserName { get; set; }



        [Column("Password", Order = 4)]
        public string Password { get; set; }



    }
}
