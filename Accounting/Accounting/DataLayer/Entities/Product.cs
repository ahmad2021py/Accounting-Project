using Accounting.DataLayer.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    [Table("Products")]
    public class Product : IBaseDbSet
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique.
        public long Row { get; set; }  //this Column auto increment To make each record (Row) unique  . And Avoid Errors .

        //-------------------------------------------------
        //[Index(IsClustered =true,IsUnique = true)] ---This column has Index by default that is Key---
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  // set this Column auto increment To make each record unique.
        [Required]
        public int ProductCode { get; set; } //must be unique for this Table
        [Required]
        public string ProductName { get; set; }
        public string Features { get; set; }
        public byte[] Picture { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
    }
}
