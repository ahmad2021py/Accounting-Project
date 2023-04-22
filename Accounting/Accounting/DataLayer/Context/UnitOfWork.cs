using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
  public  class UnitOfWork:IDisposable
    {

        // ############# فیلد های کلاس  ##########
        Accounting_DbContext db = new Accounting_DbContext();

        private IUserRepository _userRepository;


        //#############پراپرتی های کلاس#############
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(db);
                }

                return _userRepository;
            }
        }

        //--------------------------------------------------


        //############متد های کلاس ##################

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}



    
