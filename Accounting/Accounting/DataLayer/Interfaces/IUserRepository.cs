using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IUserRepository
    {

        Task<bool> UserExist(User user);
        bool UserExist(string UserName);
        bool UserExist(string userName, string userPassword);
        List<User> GetUserList();
        bool ChangeUserPassword(User user, string newUserPassword);
         bool DeleteUser(string userName);
        bool InsertToUsers(User record);
        List<User> GetUserListByUserIDFilter(int UserID);
         List<User> GetUserListByUserNameFilter(string UserName);
        List<User> GetUserListByUserRoleFilter(string Role);
        //  bool UserExist(int userid);
        //   bool UserExist(string role, string username, string password);



    }
}
