using Accounting.DataLayer.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{


    [Table("Sellers")] // this attribute is name of table 
    public class Seller : IBaseDbSet
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Row { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key] // set this Column Primary Key
        public long NationalCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(80)]
        public string City { get; set; }

        [MaxLength(80)]
        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public decimal debtor { get; set; }
        public decimal creditor { get; set; }






        //---------------------------
    }
}
