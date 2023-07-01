using Accounting.DataLayer.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    [Table("Users")]
    public class User : IBaseDbSet
    {
        [Column("Row", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Row { get; set; }
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("UserCode", Order = 1)]
        public int UserCode { get; set; }
        [Column("Role", Order = 2)]
        public string Role { get; set; }
        [StringLength(50)]
        [Column("UserName", Order = 3)]
        public string UserName { get; set; }
        [Column("Password", Order = 4)]
        public string Password { get; set; }



    }
}
