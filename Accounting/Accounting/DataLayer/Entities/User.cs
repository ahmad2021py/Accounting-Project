﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
   public class User
    {

        public string Role { get; set; }

        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string User_Password { get; set; }



    }
}
