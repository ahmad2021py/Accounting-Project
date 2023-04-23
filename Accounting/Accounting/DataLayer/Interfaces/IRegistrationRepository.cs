using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IRegistrationRepository
    {
        bool RegistrationIsValid(string username, string email);
        string GetUserPassword(string username, string email);




    }




}




