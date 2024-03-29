﻿
using Accounting.DataLayer.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities
{
    [Table("Registrations")]
    public class Registration : IBaseDbSet
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // set this Column auto increment To make each record unique
        [Column("Row", Order = 0)]
        public long Row { get; set; }


        //-------UserName and Password and Role----
        [Key] // set this Column Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegistrationsCode { get; set; } //This Column Must Be Uniqe . This Column Will Be UserCode In UserTable .



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
