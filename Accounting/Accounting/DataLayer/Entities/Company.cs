﻿using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    [Table("Companies")]
    public  class Company: IBaseDbSet
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique 
        public long Row { get; set; }
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyCode { get; set; }
        public string CompanyName { get; set; }
    }
}
