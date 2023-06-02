using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{

   public class Cheque
    {
    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public int Row { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ChequeCode { get; set; } // this Column Must be Uniqe .
        public string Bank { get; set; }
        public string BankBranch { get; set; }
        public DateTime ChequeDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }



    }
}
