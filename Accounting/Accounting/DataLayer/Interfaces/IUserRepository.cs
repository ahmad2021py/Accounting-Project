﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
  public  interface IUserRepository
    {
     
        bool UserExist(User user);
      //  bool UserExist(int userid);
     //   bool UserExist(string role, string username, string password);


    
}
}